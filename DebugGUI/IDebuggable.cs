using System.Collections.Generic;
namespace FizzleCrossword.DebugGUI;
public interface IDebuggable { List<DebugProperty> GetDebugProperties() => DebuggableHelper.GetDebugProperties(this); }
