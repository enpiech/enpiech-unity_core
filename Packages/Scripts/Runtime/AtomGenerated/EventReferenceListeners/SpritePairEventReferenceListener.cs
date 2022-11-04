using Enpiech.Core.Runtime.AtomGenerated.EventReferences;
using Enpiech.Core.Runtime.AtomGenerated.Events;
using Enpiech.Core.Runtime.AtomGenerated.Pairs;
using Enpiech.Core.Runtime.AtomGenerated.UnityEvents;
using UnityAtoms;
using UnityEngine;

namespace Enpiech.Core.Runtime.AtomGenerated.EventReferenceListeners
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