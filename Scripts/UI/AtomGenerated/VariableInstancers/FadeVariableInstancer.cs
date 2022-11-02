using Core.UI.AtomGenerated.Events;
using Core.UI.AtomGenerated.Functions;
using Core.UI.AtomGenerated.Pairs;
using Core.UI.AtomGenerated.Variables;
using Core.UI.Data;
using UnityAtoms;
using UnityEngine;

namespace Core.UI.AtomGenerated.VariableInstancers
{
    /// <summary>
    ///     Variable Instancer of type `Fade`. Inherits from `AtomVariableInstancer&lt;FadeVariable, FadePair, Fade, FadeEvent,
    ///     FadePairEvent, FadeFadeFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Fade Variable Instancer")]
    public class FadeVariableInstancer : AtomVariableInstancer<
        FadeVariable,
        FadePair,
        Fade,
        FadeEvent,
        FadePairEvent,
        FadeFadeFunction>
    {
    }
}