using System;
using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.Constants;
using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.Events;
using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.Functions;
using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.Pairs;
using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.VariableInstancers;
using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.Variables;
using UnityAtoms;

namespace Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.References
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