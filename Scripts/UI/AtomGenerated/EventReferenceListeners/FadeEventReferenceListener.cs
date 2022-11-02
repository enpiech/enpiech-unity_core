using Core.UI.AtomGenerated.EventReferences;
using Core.UI.AtomGenerated.Events;
using Core.UI.AtomGenerated.UnityEvents;
using Core.UI.Data;
using UnityAtoms;
using UnityEngine;

namespace Core.UI.AtomGenerated.EventReferenceListeners
{
    /// <summary>
    ///     Event Reference Listener of type `Fade`. Inherits from `AtomEventReferenceListener&lt;Fade, FadeEvent,
    ///     FadeEventReference, FadeUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Fade Event Reference Listener")]
    public sealed class FadeEventReferenceListener : AtomEventReferenceListener<
        Fade,
        FadeEvent,
        FadeEventReference,
        FadeUnityEvent>
    {
    }
}