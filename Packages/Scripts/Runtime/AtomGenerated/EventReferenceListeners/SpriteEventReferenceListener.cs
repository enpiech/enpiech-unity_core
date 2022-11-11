using Enpiech.Core.Runtime.AtomGenerated.EventReferences;
using Enpiech.Core.Runtime.AtomGenerated.Events;
using Enpiech.Core.Runtime.AtomGenerated.UnityEvents;
using UnityAtoms;
using UnityEngine;

namespace Enpiech.Core.Runtime.AtomGenerated.EventReferenceListeners
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