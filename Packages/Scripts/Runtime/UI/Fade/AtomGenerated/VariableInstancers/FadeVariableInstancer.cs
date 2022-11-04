using Enpiech.Core.Runtime.UI.Fade.AtomGenerated.Events;
using Enpiech.Core.Runtime.UI.Fade.AtomGenerated.Functions;
using Enpiech.Core.Runtime.UI.Fade.AtomGenerated.Pairs;
using Enpiech.Core.Runtime.UI.Fade.AtomGenerated.Variables;
using UnityAtoms;
using UnityEngine;

namespace Enpiech.Core.Runtime.UI.Fade.AtomGenerated.VariableInstancers
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
        Data.Fade,
        FadeEvent,
        FadePairEvent,
        FadeFadeFunction>
    {
    }
}