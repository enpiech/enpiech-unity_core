using System;
using Enpiech.Core.Runtime.Gameplay.Setting.AtomGenerated.Constants;
using Enpiech.Core.Runtime.Gameplay.Setting.AtomGenerated.Events;
using Enpiech.Core.Runtime.Gameplay.Setting.AtomGenerated.Functions;
using Enpiech.Core.Runtime.Gameplay.Setting.AtomGenerated.Pairs;
using Enpiech.Core.Runtime.Gameplay.Setting.AtomGenerated.VariableInstancers;
using Enpiech.Core.Runtime.Gameplay.Setting.AtomGenerated.Variables;
using UnityAtoms;

namespace Enpiech.Core.Runtime.Gameplay.Setting.AtomGenerated.References
{
    /// <summary>
    ///     Reference of type `Setting`. Inherits from `AtomReference&lt;Setting, SettingPair, SettingConstant,
    ///     SettingVariable, SettingEvent, SettingPairEvent, SettingSettingFunction, SettingVariableInstancer, AtomCollection,
    ///     AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SettingReference : AtomReference<
        Setting,
        SettingPair,
        SettingConstant,
        SettingVariable,
        SettingEvent,
        SettingPairEvent,
        SettingSettingFunction,
        SettingVariableInstancer>, IEquatable<SettingReference>
    {
        public SettingReference()
        {
        }

        public SettingReference(Setting value) : base(value)
        {
        }

        public bool Equals(SettingReference other)
        {
            return base.Equals(other);
        }

        protected override bool ValueEquals(Setting other)
        {
            throw new NotImplementedException();
        }
    }
}