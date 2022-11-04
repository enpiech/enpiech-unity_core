#if UNITY_2019_1_OR_NEWER
using Core.Gameplay.Save.AtomGenerated.Events;
using UnityAtoms.Editor;
using UnityEditor;

namespace Core.Gameplay.Save.AtomGenerated.Editor.AtomDrawers.Events
{
    /// <summary>
    ///     Event property drawer of type `SavePair`. Inherits from `AtomDrawer&lt;SavePairEvent&gt;`. Only availble in
    ///     `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SavePairEvent))]
    public class SavePairEventDrawer : AtomDrawer<SavePairEvent>
    {
    }
}
#endif