#if UNITY_2019_1_OR_NEWER
using Enpiech.Core.Runtime.UI.Fade.AtomGenerated.Events;
using Enpiech.Core.Runtime.UI.Fade.AtomGenerated.Pairs;
using UnityAtoms.Editor;
using UnityEditor;

namespace Enpiech.Core.Editor.UI.Fade.AtomGenerated.AtomEditors.Events
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