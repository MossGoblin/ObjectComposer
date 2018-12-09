using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectComposer.Models.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class CheckableAttribute : Attribute
    {
        public CheckableAttribute(string type)
        {
            this.Type = type;
        }
        public string Type { get; }
    }
}
