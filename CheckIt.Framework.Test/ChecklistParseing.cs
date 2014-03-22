using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using CheckIt.Entities;

namespace CheckIt.Framework.Test
{
    [TestClass]
    public class ChecklistParseing
    {
        [TestMethod]
        public void ParsingTest()
        {
            StringBuilder text = new StringBuilder("Titulo del Checklist" + Environment.NewLine);
            text.Append("Esta es una descripcion de la checklist." + Environment.NewLine);
            text.Append(Environment.NewLine);
            text.Append("Titulo de la Primera Seccion" + Environment.NewLine);
            text.Append(Environment.NewLine);
            text.Append("\tDescripcion del un item, esta descripcion puede ser tan larga como se desee, pero debera estar escrita en una sola linea." + Environment.NewLine);
            text.Append(Environment.NewLine);
            text.Append("\tEste es otro item, puesto que se encuentra en otra linea." + Environment.NewLine);
            text.Append("\tEste texto continua siendo parte del mismo item hasta que no se encuentre la palabra clave Item seguida de un simbolo de pipe " + Environment.NewLine);
            text.Append("\tal inicio de una nueva linea." + Environment.NewLine);
            text.Append(Environment.NewLine);
            text.Append(Environment.NewLine);
            text.Append("\t  " + Environment.NewLine);
            text.Append("\tOtro item de multiples lines, como lista enumerada. " + Environment.NewLine);
            text.Append("El primer tabilador se descarta pero el resto se mantiene. " + Environment.NewLine);
            text.Append("." + Environment.NewLine);
            text.Append("\t\t1. XXXX" + Environment.NewLine);
            text.Append("\t\t\t2. YYYY" + Environment.NewLine);
            text.Append("\t\t\t\t3. ZZZZ" + Environment.NewLine);
            text.Append(Environment.NewLine);
            text.Append("Titulo de la Segunda Seccion" + Environment.NewLine);
            text.Append(Environment.NewLine);
            text.Append("\tEste item consta de dos lineas" + Environment.NewLine);
            text.Append("Esta es la segunda linea" + Environment.NewLine);

            Checklist chklst = Checklist.Parse(text.ToString());

            string content = chklst.ToText();

            Checklist newChklst = Checklist.Parse(content.ToString());

            Assert.AreEqual(chklst.Title, newChklst.Title, "Checklist Names not equal");
            Assert.AreEqual(chklst.Description, newChklst.Description, "Checklist Description not equal");
            Assert.AreEqual(chklst.Sections.Count, newChklst.Sections.Count, "Checklist Sections.Count not equal");
            Assert.AreEqual(chklst.Sections[0].Items.Count, newChklst.Sections[0].Items.Count, "Checklist Sections[0].Items.Count not equal");
            Assert.AreEqual(chklst.Sections[1].Items.Count, newChklst.Sections[1].Items.Count, "Checklist Sections[1].Items.Count not equal");
        }
    }
}
