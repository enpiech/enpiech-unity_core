using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.Events;
using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.Functions;
using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.Pairs;
using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.Variables;
using UnityAtoms;
using UnityEngine;

namespace Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.VariableInstancers
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