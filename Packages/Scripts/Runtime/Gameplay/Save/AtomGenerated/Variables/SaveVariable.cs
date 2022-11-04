using System;
using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.Events;
using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.Functions;
using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.Pairs;
using UnityAtoms;
using UnityEngine;

namespace Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.Variables
{
    /// <summary>
    ///     Variable of type `Save`. Inherits from `AtomVariable&lt;Save, SavePair, SaveEvent, SavePairEvent, SaveSaveFunction
    ///     &gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Save", fileName = "SaveVariable")]
    public sealed class SaveVariable : AtomVariable<Save, SavePair, SaveEvent, SavePairEvent, SaveSaveFunction>
    {
        protected override bool ValueEquals(Save other)
        {
            throw new NotImplementedException();
        }
    }
}