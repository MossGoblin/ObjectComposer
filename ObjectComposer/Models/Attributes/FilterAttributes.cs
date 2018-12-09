using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectComposer.Models.Attributes
{
    public class FilterAttributes : Attribute
    {
        public FilterAttributes(FilterType type)
        {
            this.Type = type;
        }
        public FilterType Type { get; }
    }
    public enum FilterType
    {
        ScalableLesserSifter,
        ScalableGreaterSifter,
        ListableSifter,
        CheckableSifter,
        BoundedScalable,
        BoundedScalableGroup,
        ListableCount,
        ListablesGroupCount,
        CheckableCount,
        CheckablesGroupCount,
        TotalObjectCount
    }
}
