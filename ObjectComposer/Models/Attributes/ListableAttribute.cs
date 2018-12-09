using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectComposer.Models.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class ListableAttribute : Attribute
    {
        public ListableAttribute(string type)
        {
            this.Type = type;
        }
        public string Type { get; }
    }
}
