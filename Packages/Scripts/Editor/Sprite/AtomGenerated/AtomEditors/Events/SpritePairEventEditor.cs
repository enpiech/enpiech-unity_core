#if UNITY_2019_1_OR_NEWER
using Enpiech.Core.Runtime.AtomGenerated.Events;
using Enpiech.Core.Runtime.AtomGenerated.Pairs;
using UnityAtoms.Editor;
using UnityEditor;

namespace Enpiech.Core.Editor.Sprite.AtomGenerated.AtomEditors.Events
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