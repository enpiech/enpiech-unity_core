using Core.Gameplay.Save.AtomGenerated.Pairs;
using Core.Gameplay.Save.AtomGenerated.Variables;
using UnityAtoms.Editor;
using UnityEditor;

namespace Core.Gameplay.Save.AtomGenerated.Editor.AtomEditors.Variables
{
    /// <summary>
    ///     Variable Inspector of type `Save`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(SaveVariable))]
    public sealed class SaveVariableEditor : AtomVariableEditor<Save, SavePair>
    {
    }
}