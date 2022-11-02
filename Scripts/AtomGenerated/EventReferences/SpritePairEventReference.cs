using System;
using Core.AtomGenerated.EventInstancers;
using Core.AtomGenerated.Events;
using Core.AtomGenerated.Pairs;
using Core.AtomGenerated.VariableInstancers;
using Core.AtomGenerated.Variables;
using UnityAtoms;

namespace Core.AtomGenerated.EventReferences
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