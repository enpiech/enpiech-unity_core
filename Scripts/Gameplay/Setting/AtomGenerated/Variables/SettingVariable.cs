using Core.Gameplay.Setting.AtomGenerated.Events;
using Core.Gameplay.Setting.AtomGenerated.Functions;
using Core.Gameplay.Setting.AtomGenerated.Pairs;
using UnityAtoms;
using UnityEngine;

namespace Core.Gameplay.Setting.AtomGenerated.Variables
{
    /// <summary>
    ///     Variable of type `Setting`. Inherits from `AtomVariable&lt;Setting, SettingPair, SettingEvent, SettingPairEvent,
    ///     SettingSettingFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Setting", fileName = "SettingVariable")]
    public sealed class SettingVariable : AtomVariable<Setting, SettingPair, SettingEvent, SettingPairEvent, SettingSettingFunction>
    {
        protected override bool ValueEquals(Setting other)
        {
            return _value == other;
        }
    }
}