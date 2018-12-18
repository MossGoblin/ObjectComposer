using ObjectComposer.Core.Contracts;
using ObjectComposer.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectComposer.Core
{
    public class Gatherer : IGatherer
    {
        private List<IElement> objectList;

        public Gatherer()
        {
            objectList = new List<IElement>();
        }

        public List<IElement> ObjectList
        {
            get { return objectList; }
            set { objectList = value; }
        }

        public List<IElement> GetObjectList()
        {
            return ObjectList;
        }

        public void AddObject(IElement obj)
        {
            this.ObjectList.Add(obj);
        }
    }
}
