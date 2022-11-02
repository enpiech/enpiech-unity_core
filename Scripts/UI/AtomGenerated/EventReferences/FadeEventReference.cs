using System;
using Core.UI.AtomGenerated.EventInstancers;
using Core.UI.AtomGenerated.Events;
using Core.UI.AtomGenerated.VariableInstancers;
using Core.UI.AtomGenerated.Variables;
using Core.UI.Data;
using UnityAtoms;

namespace Core.UI.AtomGenerated.EventReferences
{
    /// <summary>
    ///     Event Reference of type `Fade`. Inherits from `AtomEventReference&lt;Fade, FadeVariable, FadeEvent,
    ///     FadeVariableInstancer, FadeEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class FadeEventReference : AtomEventReference<
        Fade,
        FadeVariable,
        FadeEvent,
        FadeVariableInstancer,
        FadeEventInstancer>, IGetEvent
    {
    }
}