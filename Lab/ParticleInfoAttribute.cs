using System;
using System.Collections.Generic;
using System.Text;

namespace Lab
{
    public class ParticleInfoAttribute : Attribute
    {
        private string varType;
        private string varName;

        public ParticleInfoAttribute(string varType, string varName)
        {
            this.varType = varType;
            this.varName = varName;
        }

        public string VarName
        {
            get { return varName; }
        }

        public string VarType
        {
            get { return varType; }
        }

    }
}
