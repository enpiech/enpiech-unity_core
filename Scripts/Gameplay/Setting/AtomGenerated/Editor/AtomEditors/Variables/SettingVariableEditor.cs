using Core.Gameplay.Setting.AtomGenerated.Pairs;
using Core.Gameplay.Setting.AtomGenerated.Variables;
using UnityAtoms.Editor;
using UnityEditor;

namespace Core.Gameplay.Setting.AtomGenerated.Editor.AtomEditors.Variables
{
    /// <summary>
    ///     Variable Inspector of type `Setting`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(SettingVariable))]
    public sealed class SettingVariableEditor : AtomVariableEditor<Setting, SettingPair>
    {
    }
}