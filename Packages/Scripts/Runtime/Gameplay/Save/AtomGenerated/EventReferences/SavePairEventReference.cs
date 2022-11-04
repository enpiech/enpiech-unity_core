using System;
using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.EventInstancers;
using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.Events;
using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.Pairs;
using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.VariableInstancers;
using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.Variables;
using UnityAtoms;

namespace Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.EventReferences
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