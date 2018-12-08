using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectComposer.Models.Contracts
{
    public interface IListable<LData>
    {
        Dictionary<string, LData> GetListables();
    }
}
