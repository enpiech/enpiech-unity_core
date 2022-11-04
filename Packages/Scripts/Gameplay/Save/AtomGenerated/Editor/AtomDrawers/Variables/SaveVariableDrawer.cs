#if UNITY_2019_1_OR_NEWER
using Core.Gameplay.Save.AtomGenerated.Variables;
using UnityAtoms.Editor;
using UnityEditor;

namespace Core.Gameplay.Save.AtomGenerated.Editor.AtomDrawers.Variables
{
    /// <summary>
    ///     Variable property drawer of type `Save`. Inherits from `AtomDrawer&lt;SaveVariable&gt;`. Only availble in
    ///     `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SaveVariable))]
    public class SaveVariableDrawer : VariableDrawer<SaveVariable>
    {
    }
}
#endif