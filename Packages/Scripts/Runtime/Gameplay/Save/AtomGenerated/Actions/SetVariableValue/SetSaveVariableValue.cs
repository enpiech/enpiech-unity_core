using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.Constants;
using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.Events;
using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.Functions;
using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.Pairs;
using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.References;
using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.VariableInstancers;
using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.Variables;
using UnityAtoms;
using UnityEngine;

namespace Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.Actions.SetVariableValue
{
    /// <summary>
    ///     Set variable value Action of type `Save`. Inherits from `SetVariableValue&lt;Save, SavePair, SaveVariable,
    ///     SaveConstant, SaveReference, SaveEvent, SavePairEvent, SaveVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Save", fileName = "SetSaveVariableValue")]
    public sealed class SetSaveVariableValue : SetVariableValue<
        Save,
        SavePair,
        SaveVariable,
        SaveConstant,
        SaveReference,
        SaveEvent,
        SavePairEvent,
        SaveSaveFunction,
        SaveVariableInstancer>
    {
    }
}