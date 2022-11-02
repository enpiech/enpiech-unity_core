using Core.Gameplay.Save.AtomGenerated.EventReferences;
using Core.Gameplay.Save.AtomGenerated.Events;
using Core.Gameplay.Save.AtomGenerated.UnityEvents;
using UnityAtoms;
using UnityEngine;

namespace Core.Gameplay.Save.AtomGenerated.EventReferenceListeners
{
    /// <summary>
    ///     Event Reference Listener of type `Save`. Inherits from `AtomEventReferenceListener&lt;Save, SaveEvent,
    ///     SaveEventReference, SaveUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Save Event Reference Listener")]
    public sealed class SaveEventReferenceListener : AtomEventReferenceListener<
        Save,
        SaveEvent,
        SaveEventReference,
        SaveUnityEvent>
    {
    }
}