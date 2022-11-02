#if UNITY_2019_1_OR_NEWER
using Core.Gameplay.Save.AtomGenerated.Events;
using UnityAtoms.Editor;
using UnityEditor;

namespace Core.Gameplay.Save.AtomGenerated.Editor.AtomDrawers.Events
{
    /// <summary>
    ///     Event property drawer of type `Save`. Inherits from `AtomDrawer&lt;SaveEvent&gt;`. Only availble in
    ///     `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SaveEvent))]
    public class SaveEventDrawer : AtomDrawer<SaveEvent>
    {
    }
}
#endif