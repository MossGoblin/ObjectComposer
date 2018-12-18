using ObjectComposer.Core.Contracts;
using ObjectComposer.Models;
using ObjectComposer.Models.Attributes;
using ObjectComposer.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ObjectComposer.Core
{
    class Composer : IComposer
    {
        readonly IReadOnlyCollection<IElement> inputObjectList;

        private Dictionary<string, decimal> SifterLesserScalablesList;
        private Dictionary<string, decimal> SifterGreaterScalablesList;
        private Dictionary<string, string> ListablesExclusionList;
        private Dictionary<string, bool> CheckablesExclusionList;
        private Dictionary<string[], decimal[]> BarrelsList;

        public Composer(IReadOnlyCollection<IElement> inputObjectList)
        {
            this.inputObjectList = inputObjectList;
            SifterLesserScalablesList = new Dictionary<string, decimal>();
            SifterGreaterScalablesList = new Dictionary<string, decimal>();
            ListablesExclusionList = new Dictionary<string, string>();
            CheckablesExclusionList = new Dictionary<string, bool>();
            BarrelsList = new Dictionary<string[], decimal[]>();
            // Get Filter List/Dictionary
            // Process Input List
        }

        IReadOnlyCollection<IElement> InputObjectList
        {
            get
            {
                return InputObjectList;
            }
        }
        public List<IElement> GetComposedList()
        {
            throw new NotImplementedException();
        }

        public void CreateFilter(FilterType type, params string[] args)
        {
            string varName;
            decimal filterRule;
            decimal scalableOne;
            decimal scalableTwo;
            string listableOne;
            bool checkableOne;
            switch (type)
            {
                // Sifters
                case FilterType.ScalableLesserSifter:
                    // Remove scalables that are lesser than a value
                    // Add the sifter to the SifterSingles list -- variable name, sifter values
                    // decompose arguments
                    varName = args[0];
                    scalableOne = int.Parse(args[1]);
                    // Add to list
                    SifterLesserScalablesList.Add(varName, scalableOne);
                    break;
                case FilterType.ScalableGreaterSifter:
                    // Remove scalables that are greater than a value
                    // Add the sifter to the sifterLesserScalablesList list -- variable name, sifter values
                    // decompose arguments
                    varName = args[0];
                    scalableOne = int.Parse(args[1]);
                    // Add to list
                    SifterGreaterScalablesList.Add(varName, scalableOne);
                    break;
                case FilterType.ListableSifter:
                    // Remove listables that are part of a list
                    varName = args[0];
                    listableOne = args[1];
                    ListablesExclusionList.Add(varName, listableOne);
                    break;
                case FilterType.CheckableSifter:
                    varName = args[0];
                    checkableOne = bool.Parse(args[1]);
                    CheckablesExclusionList.Add(varName, checkableOne);
                    break;
                // Filters
                case FilterType.BoundedScalable:
                    break;
                case FilterType.BoundedScalableGroup:
                    break;
                case FilterType.ListableCount:
                    break;
                case FilterType.ListablesGroupCount:
                    break;
                case FilterType.CheckableCount:
                    break;
                case FilterType.CheckablesGroupCount:
                    break;
                default:
                    break;
            }
        }

        // TODO : TESTING
        public void TestCheckablesExlusionSifter()
        {
            List<IElement> testObjectList = new List<IElement>();

            // for each item in the CheckablesExclusionList, check all items in the inputObjectList and remove them (move the rest in a new dictionary)

            // for first attempt will use only one foreach, as we'll use only one sifter

            foreach (ModelRoom obj in inputObjectList)
            {
                // Access the instance
                Type objInstType = obj.GetType();
                var objInstTypeName = obj.GetType().Name;
                var objInst = Assembly.GetAssembly(objInstType).GetTypes().FirstOrDefault(x => x.Name == objInstTypeName);
                //var objInst = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(x => x.Name == objInstTypeName);

                //var testField = objInst.BaseType.GetField("HasSecretEntrance");
                var testField = objInst.BaseType.GetProperty("HasSecretEntrance");

                ////testField.SetValue(objInst, "HasSecretEntrance");
                //var propValue = testField.GetValue(objInst);

                //var propValue = objInst.GetProperty("HasSecretEntrance").GetValue(objInst);
                var propValue = objInst.GetProperty("HasSecretEntrance").GetValue(objInstType);

                // src.GetType().GetProperty(propName).GetValue(src, null);
            }
        }
    }
}
