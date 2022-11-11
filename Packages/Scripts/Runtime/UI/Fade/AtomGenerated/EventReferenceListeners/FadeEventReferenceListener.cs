using Enpiech.Core.Runtime.UI.Fade.AtomGenerated.EventReferences;
using Enpiech.Core.Runtime.UI.Fade.AtomGenerated.Events;
using Enpiech.Core.Runtime.UI.Fade.AtomGenerated.UnityEvents;
using UnityAtoms;
using UnityEngine;

namespace Enpiech.Core.Runtime.UI.Fade.AtomGenerated.EventReferenceListeners
{
    /// <summary>
    ///     Event Reference Listener of type `Fade`. Inherits from `AtomEventReferenceListener&lt;Fade, FadeEvent,
    ///     FadeEventReference, FadeUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Fade Event Reference Listener")]
    public sealed class FadeEventReferenceListener : AtomEventReferenceListener<
        Data.Fade,
        FadeEvent,
        FadeEventReference,
        FadeUnityEvent>
    {
    }
}