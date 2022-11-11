using System;
using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.EventInstancers;
using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.Events;
using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.VariableInstancers;
using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.Variables;
using UnityAtoms;

namespace Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.EventReferences
{
    /// <summary>
    ///     Event Reference of type `Save`. Inherits from `AtomEventReference&lt;Save, SaveVariable, SaveEvent,
    ///     SaveVariableInstancer, SaveEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SaveEventReference : AtomEventReference<
        Save,
        SaveVariable,
        SaveEvent,
        SaveVariableInstancer,
        SaveEventInstancer>, IGetEvent
    {
    }
}