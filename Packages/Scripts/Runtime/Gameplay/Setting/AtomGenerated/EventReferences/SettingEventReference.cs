using System;
using Enpiech.Core.Runtime.Gameplay.Setting.AtomGenerated.EventInstancers;
using Enpiech.Core.Runtime.Gameplay.Setting.AtomGenerated.Events;
using Enpiech.Core.Runtime.Gameplay.Setting.AtomGenerated.VariableInstancers;
using Enpiech.Core.Runtime.Gameplay.Setting.AtomGenerated.Variables;
using UnityAtoms;

namespace Enpiech.Core.Runtime.Gameplay.Setting.AtomGenerated.EventReferences
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