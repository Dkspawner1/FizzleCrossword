
using System;

namespace FizzleCrossword.DebugGUI.Attributes;
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, Inherited = true)]
public class DebugVariableAttribute : Attribute
{
    public bool IsEditable { get; set; }
    public DebugVariableAttribute(bool isEditable = false)
    {
        IsEditable = isEditable;
    }

}
