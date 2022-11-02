using Core.Gameplay.Save.AtomGenerated.Events;
using Core.Gameplay.Save.AtomGenerated.Functions;
using Core.Gameplay.Save.AtomGenerated.Pairs;
using Core.Gameplay.Save.AtomGenerated.Variables;
using UnityAtoms;
using UnityEngine;

namespace Core.Gameplay.Save.AtomGenerated.VariableInstancers
{
    /// <summary>
    ///     Variable Instancer of type `Save`. Inherits from `AtomVariableInstancer&lt;SaveVariable, SavePair, Save, SaveEvent,
    ///     SavePairEvent, SaveSaveFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Save Variable Instancer")]
    public class SaveVariableInstancer : AtomVariableInstancer<
        SaveVariable,
        SavePair,
        Save,
        SaveEvent,
        SavePairEvent,
        SaveSaveFunction>
    {
    }
}