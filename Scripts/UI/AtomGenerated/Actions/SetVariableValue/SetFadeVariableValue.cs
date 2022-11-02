using Core.UI.AtomGenerated.Constants;
using Core.UI.AtomGenerated.Events;
using Core.UI.AtomGenerated.Functions;
using Core.UI.AtomGenerated.Pairs;
using Core.UI.AtomGenerated.References;
using Core.UI.AtomGenerated.VariableInstancers;
using Core.UI.AtomGenerated.Variables;
using Core.UI.Data;
using UnityAtoms;
using UnityEngine;

namespace Core.UI.AtomGenerated.Actions.SetVariableValue
{
    /// <summary>
    ///     Set variable value Action of type `Fade`. Inherits from `SetVariableValue&lt;Fade, FadePair, FadeVariable,
    ///     FadeConstant, FadeReference, FadeEvent, FadePairEvent, FadeVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Fade", fileName = "SetFadeVariableValue")]
    public sealed class SetFadeVariableValue : SetVariableValue<
        Fade,
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