using System;
using Core.AtomGenerated.Events;
using Core.AtomGenerated.Functions;
using Core.AtomGenerated.Pairs;
using UnityAtoms;
using UnityEngine;

namespace Core.AtomGenerated.Variables
{
    /// <summary>
    ///     Variable of type `Sprite`. Inherits from `AtomVariable&lt;Sprite, SpritePair, SpriteEvent, SpritePairEvent,
    ///     SpriteSpriteFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Sprite", fileName = "SpriteVariable")]
    public sealed class SpriteVariable : AtomVariable<Sprite, SpritePair, SpriteEvent, SpritePairEvent, SpriteSpriteFunction>
    {
        protected override bool ValueEquals(Sprite other)
        {
            throw new NotImplementedException();
        }
    }
}