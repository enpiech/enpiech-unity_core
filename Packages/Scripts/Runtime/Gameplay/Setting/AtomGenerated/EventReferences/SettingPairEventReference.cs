using System;
using Enpiech.Core.Runtime.Gameplay.Setting.AtomGenerated.EventInstancers;
using Enpiech.Core.Runtime.Gameplay.Setting.AtomGenerated.Events;
using Enpiech.Core.Runtime.Gameplay.Setting.AtomGenerated.Pairs;
using Enpiech.Core.Runtime.Gameplay.Setting.AtomGenerated.VariableInstancers;
using Enpiech.Core.Runtime.Gameplay.Setting.AtomGenerated.Variables;
using UnityAtoms;

namespace Enpiech.Core.Runtime.Gameplay.Setting.AtomGenerated.EventReferences
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