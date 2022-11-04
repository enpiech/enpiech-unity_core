using System;
using Enpiech.Core.Runtime.UI.Fade.AtomGenerated.EventInstancers;
using Enpiech.Core.Runtime.UI.Fade.AtomGenerated.Events;
using Enpiech.Core.Runtime.UI.Fade.AtomGenerated.Pairs;
using Enpiech.Core.Runtime.UI.Fade.AtomGenerated.VariableInstancers;
using Enpiech.Core.Runtime.UI.Fade.AtomGenerated.Variables;
using UnityAtoms;

namespace Enpiech.Core.Runtime.UI.Fade.AtomGenerated.EventReferences
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