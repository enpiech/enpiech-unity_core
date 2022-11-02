#if UNITY_2019_1_OR_NEWER
using Core.AtomGenerated.Events;
using Core.AtomGenerated.Pairs;
using UnityAtoms.Editor;
using UnityEditor;

namespace Core.AtomGenerated.Editor.AtomEditors.Events
{
    /// <summary>
    ///     Event property drawer of type `SpritePair`. Inherits from `AtomEventEditor&lt;SpritePair, SpritePairEvent&gt;`.
    ///     Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(SpritePairEvent))]
    public sealed class SpritePairEventEditor : AtomEventEditor<SpritePair, SpritePairEvent>
    {
    }
}
#endif