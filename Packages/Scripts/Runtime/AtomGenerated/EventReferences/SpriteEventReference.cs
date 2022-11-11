using System;
using Enpiech.Core.Runtime.AtomGenerated.EventInstancers;
using Enpiech.Core.Runtime.AtomGenerated.Events;
using Enpiech.Core.Runtime.AtomGenerated.VariableInstancers;
using Enpiech.Core.Runtime.AtomGenerated.Variables;
using UnityAtoms;
using UnityEngine;

namespace Enpiech.Core.Runtime.AtomGenerated.EventReferences
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