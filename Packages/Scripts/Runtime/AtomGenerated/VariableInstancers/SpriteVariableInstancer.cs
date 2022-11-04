using Enpiech.Core.Runtime.AtomGenerated.Events;
using Enpiech.Core.Runtime.AtomGenerated.Functions;
using Enpiech.Core.Runtime.AtomGenerated.Pairs;
using Enpiech.Core.Runtime.AtomGenerated.Variables;
using UnityAtoms;
using UnityEngine;

namespace Enpiech.Core.Runtime.AtomGenerated.VariableInstancers
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