using Core.AtomGenerated.EventReferences;
using Core.AtomGenerated.Events;
using Core.AtomGenerated.UnityEvents;
using UnityAtoms;
using UnityEngine;

namespace Core.AtomGenerated.EventReferenceListeners
{
    /// <summary>
    ///     Event Reference Listener of type `Sprite`. Inherits from `AtomEventReferenceListener&lt;Sprite, SpriteEvent,
    ///     SpriteEventReference, SpriteUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Sprite Event Reference Listener")]
    public sealed class SpriteEventReferenceListener : AtomEventReferenceListener<
        Sprite,
        SpriteEvent,
        SpriteEventReference,
        SpriteUnityEvent>
    {
    }
}