using Enpiech.Core.Runtime.UI.Fade.AtomGenerated.Constants;
using Enpiech.Core.Runtime.UI.Fade.AtomGenerated.Events;
using Enpiech.Core.Runtime.UI.Fade.AtomGenerated.Functions;
using Enpiech.Core.Runtime.UI.Fade.AtomGenerated.Pairs;
using Enpiech.Core.Runtime.UI.Fade.AtomGenerated.References;
using Enpiech.Core.Runtime.UI.Fade.AtomGenerated.VariableInstancers;
using Enpiech.Core.Runtime.UI.Fade.AtomGenerated.Variables;
using UnityAtoms;
using UnityEngine;

namespace Enpiech.Core.Runtime.UI.Fade.AtomGenerated.Actions.SetVariableValue
{
    /// <summary>
    ///     Set variable value Action of type `Fade`. Inherits from `SetVariableValue&lt;Fade, FadePair, FadeVariable,
    ///     FadeConstant, FadeReference, FadeEvent, FadePairEvent, FadeVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Fade", fileName = "SetFadeVariableValue")]
    public sealed class SetFadeVariableValue : SetVariableValue<
        Data.Fade,
        FadePair,
        FadeVariable,
        FadeConstant,
        FadeReference,
        FadeEvent,
        FadePairEvent,
        FadeFadeFunction,
        FadeVariableInstancer>
    {
    }
}