using ObjectComposer.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectComposer.Core.Contracts
{
    public interface IComposer
    {
        List<IElement> GetComposedList();
    }
}
