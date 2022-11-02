using System;
using Core.UI.AtomGenerated.Events;
using Core.UI.AtomGenerated.Functions;
using Core.UI.AtomGenerated.Pairs;
using Core.UI.Data;
using UnityAtoms;
using UnityEngine;

namespace Core.UI.AtomGenerated.Variables
{
    /// <summary>
    ///     Variable of type `Fade`. Inherits from `AtomVariable&lt;Fade, FadePair, FadeEvent, FadePairEvent, FadeFadeFunction
    ///     &gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Fade", fileName = "FadeVariable")]
    public sealed class FadeVariable : AtomVariable<Fade, FadePair, FadeEvent, FadePairEvent, FadeFadeFunction>
    {
        protected override bool ValueEquals(Fade other)
        {
            throw new NotImplementedException();
        }
    }
}