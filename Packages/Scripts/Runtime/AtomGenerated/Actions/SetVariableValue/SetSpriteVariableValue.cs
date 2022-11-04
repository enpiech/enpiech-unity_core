using Enpiech.Core.Runtime.AtomGenerated.Constants;
using Enpiech.Core.Runtime.AtomGenerated.Events;
using Enpiech.Core.Runtime.AtomGenerated.Functions;
using Enpiech.Core.Runtime.AtomGenerated.Pairs;
using Enpiech.Core.Runtime.AtomGenerated.References;
using Enpiech.Core.Runtime.AtomGenerated.VariableInstancers;
using Enpiech.Core.Runtime.AtomGenerated.Variables;
using UnityAtoms;
using UnityEngine;

namespace Enpiech.Core.Runtime.AtomGenerated.Actions.SetVariableValue
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