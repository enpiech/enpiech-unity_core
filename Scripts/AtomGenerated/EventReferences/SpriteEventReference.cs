using System;
using Core.AtomGenerated.EventInstancers;
using Core.AtomGenerated.Events;
using Core.AtomGenerated.VariableInstancers;
using Core.AtomGenerated.Variables;
using UnityAtoms;
using UnityEngine;

namespace Core.AtomGenerated.EventReferences
{
    /// <summary>
    ///     Event Reference of type `Sprite`. Inherits from `AtomEventReference&lt;Sprite, SpriteVariable, SpriteEvent,
    ///     SpriteVariableInstancer, SpriteEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SpriteEventReference : AtomEventReference<
        Sprite,
        SpriteVariable,
        SpriteEvent,
        SpriteVariableInstancer,
        SpriteEventInstancer>, IGetEvent
    {
    }
}