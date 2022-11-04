#if UNITY_2019_1_OR_NEWER
using Core.Gameplay.Save.AtomGenerated.ValueLists;
using UnityAtoms.Editor;
using UnityEditor;

namespace Core.Gameplay.Save.AtomGenerated.Editor.AtomDrawers.ValueLists
{
    /// <summary>
    ///     Value List property drawer of type `Save`. Inherits from `AtomDrawer&lt;SaveValueList&gt;`. Only availble in
    ///     `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SaveValueList))]
    public class SaveValueListDrawer : AtomDrawer<SaveValueList>
    {
    }
}
#endif