using ObjectComposer.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectComposer.Models
{
    public class SampleObject<LData, SData> : IListable<LData>, IScalable<SData>
    {
        private LData subName;
        private LData superName;
        private SData width;
        private SData height;

        public SampleObject(LData superName, LData subName, SData height, SData width)
        {
            this.SuperName = superName;
            this.SubName = subName;
            this.Height = height;
            this.Width = width;
        }

        public SData Height
        {
            get { return height; }
            set { height = value; }
        }


        public SData Width
        {
            get { return width; }
            set { width = value; }
        }


        public LData SuperName
        {
            get { return superName; }
            set { superName = value; }
        }


        public LData SubName
        {
            get { return subName; }
            set { subName = value; }
        }


        public Dictionary<string, LData> GetListables()
        {
            Dictionary<string, LData> listables = new Dictionary<string, LData>();

            listables.Add("SubName", SubName);
            listables.Add("SuperName", SuperName);

            return listables;
        }

        public Dictionary<string, SData> GetScalables()
        {
            Dictionary<string, SData> scalables = new Dictionary<string, SData>();

            scalables.Add("Width", Width);
            scalables.Add("Height", Height);

            return scalables;
        }
    }
}
