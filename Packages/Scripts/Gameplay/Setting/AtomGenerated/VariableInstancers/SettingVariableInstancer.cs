using Core.Gameplay.Setting.AtomGenerated.Events;
using Core.Gameplay.Setting.AtomGenerated.Functions;
using Core.Gameplay.Setting.AtomGenerated.Pairs;
using Core.Gameplay.Setting.AtomGenerated.Variables;
using UnityAtoms;
using UnityEngine;

namespace Core.Gameplay.Setting.AtomGenerated.VariableInstancers
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