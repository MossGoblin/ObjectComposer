using ObjectComposer.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectComposer.Core.Tools
{
    public class ObjectSorter<LData, SData> : ISorter<LData, SData>
    {
        private Dictionary<string, LData> listables;
        private Dictionary<string, SData> scalables;

        public Dictionary<string, SData> Scalables
        {
            get { return scalables; }
            set { scalables = value; }
        }

        public Dictionary<string, LData> Listables
        {
            get { return listables; }
            set { listables = value; }
        }

        public Dictionary<string, LData> SortedListables(Dictionary<string, LData> listables)
        {
            Dictionary<string, LData> resultListables = new Dictionary<string, LData>();
            resultListables = listables.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            return resultListables;
        }

        public Dictionary<string, SData> SortedScalables(Dictionary<string, SData> scalables)
        {
            Dictionary<string, SData> resultScalables = new Dictionary<string, SData>();
            resultScalables = scalables.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            return resultScalables; // TODO : Something is wrong with the sorting
        }
    }
}
