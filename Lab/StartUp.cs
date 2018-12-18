using System;
using System.Collections.Generic;
using System.Text;

namespace Lab
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            factory.GetParticleInfo();
        }
    }
}
