#if UNITY_2019_1_OR_NEWER
using Core.UI.AtomGenerated.Events;
using UnityAtoms.Editor;
using UnityEditor;

namespace Core.UI.AtomGenerated.Editor.AtomDrawers.Events
{
    /// <summary>
    ///     Event property drawer of type `Fade`. Inherits from `AtomDrawer&lt;FadeEvent&gt;`. Only availble in
    ///     `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(FadeEvent))]
    public class FadeEventDrawer : AtomDrawer<FadeEvent>
    {
    }
}
#endif