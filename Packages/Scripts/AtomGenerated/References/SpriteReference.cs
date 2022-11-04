using System;
using Core.AtomGenerated.Constants;
using Core.AtomGenerated.Events;
using Core.AtomGenerated.Functions;
using Core.AtomGenerated.Pairs;
using Core.AtomGenerated.VariableInstancers;
using Core.AtomGenerated.Variables;
using UnityAtoms;
using UnityEngine;

namespace Core.AtomGenerated.References
{
    /// <summary>
    ///     Reference of type `Sprite`. Inherits from `AtomReference&lt;Sprite, SpritePair, SpriteConstant, SpriteVariable,
    ///     SpriteEvent, SpritePairEvent, SpriteSpriteFunction, SpriteVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SpriteReference : AtomReference<
        Sprite,
        SpritePair,
        SpriteConstant,
        SpriteVariable,
        SpriteEvent,
        SpritePairEvent,
        SpriteSpriteFunction,
        SpriteVariableInstancer>, IEquatable<SpriteReference>
    {
        public SpriteReference()
        {
        }

        public SpriteReference(Sprite value) : base(value)
        {
        }

        public bool Equals(SpriteReference other)
        {
            return base.Equals(other);
        }

        protected override bool ValueEquals(Sprite other)
        {
            throw new NotImplementedException();
        }
    }
}