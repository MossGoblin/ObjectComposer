using ObjectComposer.Core.Tools;
using ObjectComposer.Models;
using ObjectComposer.Models.Contracts;
using System;

namespace ObjectComposer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            SampleObject<string, int> sampleObjectOne = new SampleObject<string, int>("Alpha", "Omega", 5, 4);
            SampleObject<string, decimal> sampleObjectTwo = new SampleObject<string, decimal>("Alpha", "Omega", 5.5m, 3.5m);

            var resListables = sampleObjectOne.GetListables();
            var resScalablesOne = sampleObjectOne.GetScalables();
            var resScalablesTwo = sampleObjectTwo.GetScalables();

            ObjectSorter<string, int> objSorterOne = new ObjectSorter<string, int>();
            ObjectSorter<string, decimal> objSorterTwo = new ObjectSorter<string, decimal>();

            var sortedListablesOne = objSorterOne.SortedListables(resListables);
            var sortedScalablesOne = objSorterOne.SortedScalables(resScalablesOne);
            var sortedScalablesTwo = objSorterTwo.SortedScalables(resScalablesTwo);

            Console.ReadLine();

        }
    }
}
