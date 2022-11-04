using System;
using Core.Gameplay.Save.AtomGenerated.EventInstancers;
using Core.Gameplay.Save.AtomGenerated.Events;
using Core.Gameplay.Save.AtomGenerated.VariableInstancers;
using Core.Gameplay.Save.AtomGenerated.Variables;
using UnityAtoms;

namespace Core.Gameplay.Save.AtomGenerated.EventReferences
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