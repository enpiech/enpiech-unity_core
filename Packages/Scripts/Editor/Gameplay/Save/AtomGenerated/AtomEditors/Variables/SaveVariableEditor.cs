using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.Pairs;
using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.Variables;
using UnityAtoms.Editor;
using UnityEditor;

namespace Enpiech.Core.Editor.Gameplay.Save.AtomGenerated.AtomEditors.Variables
{
    /// <summary>
    ///     Variable Inspector of type `Save`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(SaveVariable))]
    public sealed class SaveVariableEditor : AtomVariableEditor<Runtime.Gameplay.Save.Save, SavePair>
    {
    }
}