using System;
using Enpiech.Core.Runtime.UI.Fade.AtomGenerated.Constants;
using Enpiech.Core.Runtime.UI.Fade.AtomGenerated.Events;
using Enpiech.Core.Runtime.UI.Fade.AtomGenerated.Functions;
using Enpiech.Core.Runtime.UI.Fade.AtomGenerated.Pairs;
using Enpiech.Core.Runtime.UI.Fade.AtomGenerated.VariableInstancers;
using Enpiech.Core.Runtime.UI.Fade.AtomGenerated.Variables;
using UnityAtoms;

namespace Enpiech.Core.Runtime.UI.Fade.AtomGenerated.References
{
    /// <summary>
    ///     Reference of type `Fade`. Inherits from `AtomReference&lt;Fade, FadePair, FadeConstant, FadeVariable, FadeEvent,
    ///     FadePairEvent, FadeFadeFunction, FadeVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class FadeReference : AtomReference<
        Data.Fade,
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

        public FadeReference(Data.Fade value) : base(value)
        {
        }

        public bool Equals(FadeReference other)
        {
            return base.Equals(other);
        }

        protected override bool ValueEquals(Data.Fade other)
        {
            throw new NotImplementedException();
        }
    }
}