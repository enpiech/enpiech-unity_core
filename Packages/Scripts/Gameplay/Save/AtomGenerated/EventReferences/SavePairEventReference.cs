using System;
using Core.Gameplay.Save.AtomGenerated.EventInstancers;
using Core.Gameplay.Save.AtomGenerated.Events;
using Core.Gameplay.Save.AtomGenerated.Pairs;
using Core.Gameplay.Save.AtomGenerated.VariableInstancers;
using Core.Gameplay.Save.AtomGenerated.Variables;
using UnityAtoms;

namespace Core.Gameplay.Save.AtomGenerated.EventReferences
{
    /// <summary>
    ///     Event Reference of type `SavePair`. Inherits from `AtomEventReference&lt;SavePair, SaveVariable, SavePairEvent,
    ///     SaveVariableInstancer, SavePairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SavePairEventReference : AtomEventReference<
        SavePair,
        SaveVariable,
        SavePairEvent,
        SaveVariableInstancer,
        SavePairEventInstancer>, IGetEvent
    {
    }
}