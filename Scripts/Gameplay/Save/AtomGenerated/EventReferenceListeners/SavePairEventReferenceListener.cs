using Core.Gameplay.Save.AtomGenerated.EventReferences;
using Core.Gameplay.Save.AtomGenerated.Events;
using Core.Gameplay.Save.AtomGenerated.Pairs;
using Core.Gameplay.Save.AtomGenerated.UnityEvents;
using UnityAtoms;
using UnityEngine;

namespace Core.Gameplay.Save.AtomGenerated.EventReferenceListeners
{
    /// <summary>
    ///     Event Reference Listener of type `SavePair`. Inherits from `AtomEventReferenceListener&lt;SavePair, SavePairEvent,
    ///     SavePairEventReference, SavePairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/SavePair Event Reference Listener")]
    public sealed class SavePairEventReferenceListener : AtomEventReferenceListener<
        SavePair,
        SavePairEvent,
        SavePairEventReference,
        SavePairUnityEvent>
    {
    }
}