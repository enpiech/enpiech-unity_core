using System;
using Core.Gameplay.Setting.AtomGenerated.EventInstancers;
using Core.Gameplay.Setting.AtomGenerated.Events;
using Core.Gameplay.Setting.AtomGenerated.VariableInstancers;
using Core.Gameplay.Setting.AtomGenerated.Variables;
using UnityAtoms;

namespace Core.Gameplay.Setting.AtomGenerated.EventReferences
{
    /// <summary>
    ///     Event Reference of type `Setting`. Inherits from `AtomEventReference&lt;Setting, SettingVariable, SettingEvent,
    ///     SettingVariableInstancer, SettingEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SettingEventReference : AtomEventReference<
        Setting,
        SettingVariable,
        SettingEvent,
        SettingVariableInstancer,
        SettingEventInstancer>, IGetEvent
    {
    }
}