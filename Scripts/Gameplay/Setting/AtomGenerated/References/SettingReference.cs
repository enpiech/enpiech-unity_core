using System;
using Core.Gameplay.Setting.AtomGenerated.Constants;
using Core.Gameplay.Setting.AtomGenerated.Events;
using Core.Gameplay.Setting.AtomGenerated.Functions;
using Core.Gameplay.Setting.AtomGenerated.Pairs;
using Core.Gameplay.Setting.AtomGenerated.VariableInstancers;
using Core.Gameplay.Setting.AtomGenerated.Variables;
using UnityAtoms;

namespace Core.Gameplay.Setting.AtomGenerated.References
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