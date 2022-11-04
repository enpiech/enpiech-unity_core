#if UNITY_2019_1_OR_NEWER
using Core.UI.AtomGenerated.Events;
using Core.UI.AtomGenerated.Pairs;
using UnityAtoms.Editor;
using UnityEditor;

namespace Core.UI.AtomGenerated.Editor.AtomEditors.Events
{
    /// <summary>
    ///     Event property drawer of type `FadePair`. Inherits from `AtomEventEditor&lt;FadePair, FadePairEvent&gt;`. Only
    ///     availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(FadePairEvent))]
    public sealed class FadePairEventEditor : AtomEventEditor<FadePair, FadePairEvent>
    {
    }
}
#endif