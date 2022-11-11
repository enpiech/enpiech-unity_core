using System;
using Enpiech.Core.Runtime.AtomGenerated.EventInstancers;
using Enpiech.Core.Runtime.AtomGenerated.Events;
using Enpiech.Core.Runtime.AtomGenerated.Pairs;
using Enpiech.Core.Runtime.AtomGenerated.VariableInstancers;
using Enpiech.Core.Runtime.AtomGenerated.Variables;
using UnityAtoms;

namespace Enpiech.Core.Runtime.AtomGenerated.EventReferences
{
    /// <summary>
    ///     Event Reference of type `SpritePair`. Inherits from `AtomEventReference&lt;SpritePair, SpriteVariable,
    ///     SpritePairEvent, SpriteVariableInstancer, SpritePairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SpritePairEventReference : AtomEventReference<
        SpritePair,
        SpriteVariable,
        SpritePairEvent,
        SpriteVariableInstancer,
        SpritePairEventInstancer>, IGetEvent
    {
    }
}