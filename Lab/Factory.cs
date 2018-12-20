using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            List<PropertyInfo> propInfo = new List<PropertyInfo>();



            // get the properties
            PropertyInfo[] typeProperties = particle.GetProperties();

            foreach (var item in typeProperties)
            {
                Console.WriteLine(item.ToString());
                var varAttr = item.GetCustomAttribute<ParticleInfoAttribute>();
                Console.WriteLine(varAttr.TypeId);
                Console.WriteLine(varAttr.VarType);
                Console.WriteLine(varAttr.VarName);
                Console.WriteLine();
                propInfo.Add(item);
            }

            // Print the PropInfo
            List<PropertyInfo> ordList =  propInfo.OrderBy(p => p.GetCustomAttribute<ParticleInfoAttribute>().VarType).ThenBy(p => p.GetCustomAttribute<ParticleInfoAttribute>().VarName).ToList();
            foreach (var item in ordList)
            {
                Console.WriteLine(item.Name);
            }

            // TODO : A proof of a well-known concept!
            var selectedProp = ordList.FirstOrDefault(p => p.GetCustomAttribute<ParticleInfoAttribute>().VarName == "scale");
            Console.WriteLine(selectedProp.Name);

            // get the fields
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
