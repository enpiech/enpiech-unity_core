using Core.UI.AtomGenerated.EventReferences;
using Core.UI.AtomGenerated.Events;
using Core.UI.AtomGenerated.Pairs;
using Core.UI.AtomGenerated.UnityEvents;
using UnityAtoms;
using UnityEngine;

namespace Core.UI.AtomGenerated.EventReferenceListeners
{
    /// <summary>
    ///     Event Reference Listener of type `FadePair`. Inherits from `AtomEventReferenceListener&lt;FadePair, FadePairEvent,
    ///     FadePairEventReference, FadePairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/FadePair Event Reference Listener")]
    public sealed class FadePairEventReferenceListener : AtomEventReferenceListener<
        FadePair,
        FadePairEvent,
        FadePairEventReference,
        FadePairUnityEvent>
    {
    }
}