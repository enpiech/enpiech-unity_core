#if UNITY_2019_1_OR_NEWER
using Core.AtomGenerated.Events;
using UnityAtoms.Editor;
using UnityEditor;
using UnityEngine;

namespace Core.AtomGenerated.Editor.AtomEditors.Events
{
    /// <summary>
    ///     Event property drawer of type `Sprite`. Inherits from `AtomEventEditor&lt;Sprite, SpriteEvent&gt;`. Only availble
    ///     in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(SpriteEvent))]
    public sealed class SpriteEventEditor : AtomEventEditor<Sprite, SpriteEvent>
    {
    }
}
#endif