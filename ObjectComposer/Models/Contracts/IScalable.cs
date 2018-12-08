using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectComposer.Models.Contracts
{
    public interface IScalable<SData>
    {
        Dictionary<string, SData> GetScalables();
    }
}
