using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Lab
{
    class Factory
    {
        public string GetParticleInfo()
        {
            Type particle = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(p => p.Name == "Particle");
            Console.WriteLine(particle.Name.ToString());

            PropertyInfo[] typeProperties = particle.GetProperties();

            foreach (var item in typeProperties)
            {
                Console.WriteLine(item.ToString());
            }

            // Why the typeFields is empty ??
            FieldInfo[] typeFields = particle.GetFields();

            foreach (var item in typeFields)
            {
                Console.WriteLine(item.ToString());
            }

            return string.Empty;
        }

    }
}
