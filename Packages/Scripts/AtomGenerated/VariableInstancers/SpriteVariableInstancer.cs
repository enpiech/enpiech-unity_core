using Core.AtomGenerated.Events;
using Core.AtomGenerated.Functions;
using Core.AtomGenerated.Pairs;
using Core.AtomGenerated.Variables;
using UnityAtoms;
using UnityEngine;

namespace Core.AtomGenerated.VariableInstancers
{
    /// <summary>
    ///     Variable Instancer of type `Sprite`. Inherits from `AtomVariableInstancer&lt;SpriteVariable, SpritePair, Sprite,
    ///     SpriteEvent, SpritePairEvent, SpriteSpriteFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Sprite Variable Instancer")]
    public class SpriteVariableInstancer : AtomVariableInstancer<
        SpriteVariable,
        SpritePair,
        Sprite,
        SpriteEvent,
        SpritePairEvent,
        SpriteSpriteFunction>
    {
    }
}