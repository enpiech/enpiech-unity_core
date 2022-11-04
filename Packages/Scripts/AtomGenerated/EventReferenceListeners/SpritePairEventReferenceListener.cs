using Core.AtomGenerated.EventReferences;
using Core.AtomGenerated.Events;
using Core.AtomGenerated.Pairs;
using Core.AtomGenerated.UnityEvents;
using UnityAtoms;
using UnityEngine;

namespace Core.AtomGenerated.EventReferenceListeners
{
    /// <summary>
    ///     Event Reference Listener of type `SpritePair`. Inherits from `AtomEventReferenceListener&lt;SpritePair,
    ///     SpritePairEvent, SpritePairEventReference, SpritePairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/SpritePair Event Reference Listener")]
    public sealed class SpritePairEventReferenceListener : AtomEventReferenceListener<
        SpritePair,
        SpritePairEvent,
        SpritePairEventReference,
        SpritePairUnityEvent>
    {
    }
}