using System;
using Core.UI.AtomGenerated.EventInstancers;
using Core.UI.AtomGenerated.Events;
using Core.UI.AtomGenerated.Pairs;
using Core.UI.AtomGenerated.VariableInstancers;
using Core.UI.AtomGenerated.Variables;
using UnityAtoms;

namespace Core.UI.AtomGenerated.EventReferences
{
    /// <summary>
    ///     Event Reference of type `FadePair`. Inherits from `AtomEventReference&lt;FadePair, FadeVariable, FadePairEvent,
    ///     FadeVariableInstancer, FadePairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class FadePairEventReference : AtomEventReference<
        FadePair,
        FadeVariable,
        FadePairEvent,
        FadeVariableInstancer,
        FadePairEventInstancer>, IGetEvent
    {
    }
}