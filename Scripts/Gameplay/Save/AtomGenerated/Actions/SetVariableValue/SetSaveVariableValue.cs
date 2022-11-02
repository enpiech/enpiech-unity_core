using Core.Gameplay.Save.AtomGenerated.Constants;
using Core.Gameplay.Save.AtomGenerated.Events;
using Core.Gameplay.Save.AtomGenerated.Functions;
using Core.Gameplay.Save.AtomGenerated.Pairs;
using Core.Gameplay.Save.AtomGenerated.References;
using Core.Gameplay.Save.AtomGenerated.VariableInstancers;
using Core.Gameplay.Save.AtomGenerated.Variables;
using UnityAtoms;
using UnityEngine;

namespace Core.Gameplay.Save.AtomGenerated.Actions.SetVariableValue
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