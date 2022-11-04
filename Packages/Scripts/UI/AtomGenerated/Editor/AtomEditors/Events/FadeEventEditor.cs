#if UNITY_2019_1_OR_NEWER
using Core.UI.AtomGenerated.Events;
using Core.UI.Data;
using UnityAtoms.Editor;
using UnityEditor;

namespace Core.UI.AtomGenerated.Editor.AtomEditors.Events
{
    /// <summary>
    ///     Event property drawer of type `Fade`. Inherits from `AtomEventEditor&lt;Fade, FadeEvent&gt;`. Only availble in
    ///     `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(FadeEvent))]
    public sealed class FadeEventEditor : AtomEventEditor<Fade, FadeEvent>
    {
    }
}
#endif