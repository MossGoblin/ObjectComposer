using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectComposer.Core.Contracts
{
    public interface ISorter<LData, SData>
    {
        Dictionary<string, LData> SortedListables(Dictionary<string, LData> listables);
        Dictionary<string, SData> SortedScalables(Dictionary<string, SData> scalables);
    }
}
