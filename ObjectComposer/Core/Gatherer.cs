using ObjectComposer.Core.Contracts;
using ObjectComposer.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectComposer.Core
{
    public class Gatherer : IGatherer
    {
        private List<IComposite> objectList;

        public Gatherer()
        {
            objectList = new List<IComposite>();
        }

        public List<IComposite> ObjectList
        {
            get { return objectList; }
            set { objectList = value; }
        }

        public List<IComposite> GetObjectList()
        {
            return ObjectList;
        }

        public void AddObject(IComposite obj)
        {
            this.ObjectList.Add(obj);
        }
    }
}
