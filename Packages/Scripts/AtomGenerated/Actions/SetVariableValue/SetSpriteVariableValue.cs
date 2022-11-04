using Core.AtomGenerated.Constants;
using Core.AtomGenerated.Events;
using Core.AtomGenerated.Functions;
using Core.AtomGenerated.Pairs;
using Core.AtomGenerated.References;
using Core.AtomGenerated.VariableInstancers;
using Core.AtomGenerated.Variables;
using UnityAtoms;
using UnityEngine;

namespace Core.AtomGenerated.Actions.SetVariableValue
{
    /// <summary>
    ///     Set variable value Action of type `Sprite`. Inherits from `SetVariableValue&lt;Sprite, SpritePair, SpriteVariable,
    ///     SpriteConstant, SpriteReference, SpriteEvent, SpritePairEvent, SpriteVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Sprite", fileName = "SetSpriteVariableValue")]
    public sealed class SetSpriteVariableValue : SetVariableValue<
        Sprite,
        SpritePair,
        SpriteVariable,
        SpriteConstant,
        SpriteReference,
        SpriteEvent,
        SpritePairEvent,
        SpriteSpriteFunction,
        SpriteVariableInstancer>
    {
    }
}