using CheckIt.Entities.Entities;
using System;
using System.Text;
using System.Text.RegularExpressions;

namespace CheckIt.Entities
{
    public static class ChecklistExtensions
    {
        public static string ToText(this Checklist chklst)
        {
            StringBuilder content = new StringBuilder();
            
            //Title & Description
            content.Append(chklst.Title + Environment.NewLine);
            if(!String.IsNullOrWhiteSpace(chklst.Description))
                content.Append(chklst.Description + Environment.NewLine);

            content.Append(Environment.NewLine);

            //Sections
            foreach(Section section in chklst.Sections)
            {
                content.Append(section.Name.ToString() + Environment.NewLine);
                content.Append(Environment.NewLine);

                foreach(Item item in section.Items)
                {
                    //Items
                    content.Append("\t" + item.Content + Environment.NewLine);
                    content.Append(Environment.NewLine);
                }
            }

            return content.ToString();
        }
    }

    public partial class Checklist
    {
        public enum LineType
        {
            Unknown,
            Title,
            Section,
            Item
        }

        public static Checklist Parse(string text)
        {
            if (String.IsNullOrWhiteSpace(text))
                return null;

            Checklist chklst = new Checklist();
            chklst.Content = text;

            //
            var lines = text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None );

            Section currentSection;
            bool secFlag = true;
            int ln = -1;
            while(++ln < lines.Length)
            {
                currentSection = chklst.Sections[chklst.Sections.Count - 1];
                string line = lines[ln];

                if(!String.IsNullOrWhiteSpace(line))
                {
                    //First non empty line will always be the name
                    if(String.IsNullOrWhiteSpace( chklst.Title ))
                    {
                        //Title & Description
                        SetContent<Checklist>(chklst, ref ln, lines);
                    }
                    else
                    {
                        switch (GetLineType(line))
                        {
                            case LineType.Section:
                                //First section is always replaced
                                if (secFlag)
                                {
                                    chklst.Sections[chklst.Sections.Count - 1] = GetContentStringSettable<Section>(ref ln, lines);
                                    secFlag = false;
                                }
                                else
                                {
                                    chklst.Sections.Add(GetContentStringSettable<Section>(ref ln, lines));
                                }
                                break;
                            case LineType.Item:
                                currentSection.Items.Add(GetContentStringSettable<DichotomyItem>(ref ln, lines));
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

            return chklst;
        }

        private static T GetContentStringSettable<T>(ref int idx, string[] lines) where T : IContentStringSettable
        {
            T result = (T)Activator.CreateInstance(typeof(T));

            SetContent<T>(result, ref idx, lines);

            return result;
        }

        private static void SetContent<T>(T contentSettable, ref int idx, string[] lines) where T : IContentStringSettable
        {
            StringBuilder content = new StringBuilder();
            while (idx < lines.Length && !Regex.IsMatch(lines[idx], @"^[ \t]*$"))
            {
                content.AppendLine(lines[idx]);
                ++idx;
            }

            string contentString = content.ToString();
            //Remove all new lines at the end and first tab
            string finalNewLines = String.Format(@"[{0}]*$", Environment.NewLine);
            contentString = Regex.Replace(contentString, finalNewLines, "");
            contentString = Regex.Replace(contentString, @"^[\t]", "");

            contentSettable.SetContentString(contentString);
        }

        private static LineType GetLineType(string line)
        {
            if (line.StartsWith("\t"))
            {
                //validate white spaces
                if (!String.IsNullOrWhiteSpace(line))
                {
                    return LineType.Item;
                }
            }
            else
            {
                //validate white spaces
                if (!String.IsNullOrWhiteSpace(line))
                {
                    return LineType.Section;
                }
            }

            return LineType.Unknown;
        }
    }
}
