using Enpiech.Core.Runtime.Gameplay.Setting.AtomGenerated.Events;
using Enpiech.Core.Runtime.Gameplay.Setting.AtomGenerated.Functions;
using Enpiech.Core.Runtime.Gameplay.Setting.AtomGenerated.Pairs;
using Enpiech.Core.Runtime.Gameplay.Setting.AtomGenerated.Variables;
using UnityAtoms;
using UnityEngine;

namespace Enpiech.Core.Runtime.Gameplay.Setting.AtomGenerated.VariableInstancers
{
    /// <summary>
    ///     Variable Instancer of type `Setting`. Inherits from `AtomVariableInstancer&lt;SettingVariable, SettingPair,
    ///     Setting, SettingEvent, SettingPairEvent, SettingSettingFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Setting Variable Instancer")]
    public class SettingVariableInstancer : AtomVariableInstancer<
        SettingVariable,
        SettingPair,
        Setting,
        SettingEvent,
        SettingPairEvent,
        SettingSettingFunction>
    {
    }
}