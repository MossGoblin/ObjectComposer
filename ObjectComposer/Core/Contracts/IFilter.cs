using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectComposer.Core.Contracts
{
    public interface IFilter
    {
        Dictionary<string[], decimal[]> GetFilterRule();
    }
}
