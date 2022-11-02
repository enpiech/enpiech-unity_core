using System;
using Core.Gameplay.Save.AtomGenerated.Constants;
using Core.Gameplay.Save.AtomGenerated.Events;
using Core.Gameplay.Save.AtomGenerated.Functions;
using Core.Gameplay.Save.AtomGenerated.Pairs;
using Core.Gameplay.Save.AtomGenerated.VariableInstancers;
using Core.Gameplay.Save.AtomGenerated.Variables;
using UnityAtoms;

namespace Core.Gameplay.Save.AtomGenerated.References
{
    /// <summary>
    ///     Reference of type `Save`. Inherits from `AtomReference&lt;Save, SavePair, SaveConstant, SaveVariable, SaveEvent,
    ///     SavePairEvent, SaveSaveFunction, SaveVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SaveReference : AtomReference<
        Save,
        SavePair,
        SaveConstant,
        SaveVariable,
        SaveEvent,
        SavePairEvent,
        SaveSaveFunction,
        SaveVariableInstancer>, IEquatable<SaveReference>
    {
        public SaveReference()
        {
        }

        public SaveReference(Save value) : base(value)
        {
        }

        public bool Equals(SaveReference other)
        {
            return base.Equals(other);
        }

        protected override bool ValueEquals(Save other)
        {
            throw new NotImplementedException();
        }
    }
}