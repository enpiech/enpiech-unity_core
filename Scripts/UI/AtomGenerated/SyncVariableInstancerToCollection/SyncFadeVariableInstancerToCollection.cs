using Core.UI.AtomGenerated.VariableInstancers;
using Core.UI.AtomGenerated.Variables;
using Core.UI.Data;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Core.UI.AtomGenerated.SyncVariableInstancerToCollection
{
    /// <summary>
    ///     Adds Variable Instancer's Variable of type Fade to a Collection or List on OnEnable and removes it on OnDestroy.
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync Fade Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncFadeVariableInstancerToCollection : SyncVariableInstancerToCollection<Fade, FadeVariable, FadeVariableInstancer>
    {
    }
}