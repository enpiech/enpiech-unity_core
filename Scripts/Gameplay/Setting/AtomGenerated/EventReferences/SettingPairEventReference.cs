using System;
using Core.Gameplay.Setting.AtomGenerated.EventInstancers;
using Core.Gameplay.Setting.AtomGenerated.Events;
using Core.Gameplay.Setting.AtomGenerated.Pairs;
using Core.Gameplay.Setting.AtomGenerated.VariableInstancers;
using Core.Gameplay.Setting.AtomGenerated.Variables;
using UnityAtoms;

namespace Core.Gameplay.Setting.AtomGenerated.EventReferences
{
    /// <summary>
    ///     Event Reference of type `SettingPair`. Inherits from `AtomEventReference&lt;SettingPair, SettingVariable,
    ///     SettingPairEvent, SettingVariableInstancer, SettingPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SettingPairEventReference : AtomEventReference<
        SettingPair,
        SettingVariable,
        SettingPairEvent,
        SettingVariableInstancer,
        SettingPairEventInstancer>, IGetEvent
    {
    }
}