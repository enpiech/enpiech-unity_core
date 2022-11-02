using System;
using Core.UI.AtomGenerated.Constants;
using Core.UI.AtomGenerated.Events;
using Core.UI.AtomGenerated.Functions;
using Core.UI.AtomGenerated.Pairs;
using Core.UI.AtomGenerated.VariableInstancers;
using Core.UI.AtomGenerated.Variables;
using Core.UI.Data;
using UnityAtoms;

namespace Core.UI.AtomGenerated.References
{
    /// <summary>
    ///     Reference of type `Fade`. Inherits from `AtomReference&lt;Fade, FadePair, FadeConstant, FadeVariable, FadeEvent,
    ///     FadePairEvent, FadeFadeFunction, FadeVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class FadeReference : AtomReference<
        Fade,
        FadePair,
        FadeConstant,
        FadeVariable,
        FadeEvent,
        FadePairEvent,
        FadeFadeFunction,
        FadeVariableInstancer>, IEquatable<FadeReference>
    {
        public FadeReference()
        {
        }

        public FadeReference(Fade value) : base(value)
        {
        }

        public bool Equals(FadeReference other)
        {
            return base.Equals(other);
        }

        protected override bool ValueEquals(Fade other)
        {
            throw new NotImplementedException();
        }
    }
}