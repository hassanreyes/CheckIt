using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckIt.Web.Models
{
    public class TreeViewModel
    {
        public TreeViewModel()
        {
            this.Subfolders = new List<TreeViewModel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public IList<TreeViewModel> Subfolders { get; private set; }
        public bool IsLeaf
        {
            get
            {
                return this.Subfolders.Count == 0;
            }
        }
    }
}