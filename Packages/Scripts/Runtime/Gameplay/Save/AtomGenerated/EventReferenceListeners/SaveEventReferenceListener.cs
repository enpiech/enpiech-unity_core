using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.EventReferences;
using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.Events;
using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.UnityEvents;
using UnityAtoms;
using UnityEngine;

namespace Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.EventReferenceListeners
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