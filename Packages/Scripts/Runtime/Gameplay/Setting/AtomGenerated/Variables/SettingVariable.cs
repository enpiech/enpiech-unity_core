using Enpiech.Core.Runtime.Gameplay.Setting.AtomGenerated.Events;
using Enpiech.Core.Runtime.Gameplay.Setting.AtomGenerated.Functions;
using Enpiech.Core.Runtime.Gameplay.Setting.AtomGenerated.Pairs;
using UnityAtoms;
using UnityEngine;

namespace Enpiech.Core.Runtime.Gameplay.Setting.AtomGenerated.Variables
{
    /// <summary>
    ///     Variable of type `Setting`. Inherits from `AtomVariable&lt;Setting, SettingPair, SettingEvent, SettingPairEvent,
    ///     SettingSettingFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Setting", fileName = "SettingVariable")]
    public sealed class SettingVariable : AtomVariable<Setting, SettingPair, SettingEvent, SettingPairEvent,
        SettingSettingFunction>
    {
        protected override bool ValueEquals(Setting other)
        {
            return _value == other;
        }
    }
}