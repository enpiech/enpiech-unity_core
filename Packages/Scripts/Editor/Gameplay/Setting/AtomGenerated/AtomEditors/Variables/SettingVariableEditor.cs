using Enpiech.Core.Runtime.Gameplay.Setting.AtomGenerated.Pairs;
using Enpiech.Core.Runtime.Gameplay.Setting.AtomGenerated.Variables;
using UnityAtoms.Editor;
using UnityEditor;

namespace Enpiech.Core.Editor.Gameplay.Setting.AtomGenerated.AtomEditors.Variables
{
    /// <summary>
    ///     Variable Inspector of type `Setting`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(SettingVariable))]
    public sealed class SettingVariableEditor : AtomVariableEditor<Runtime.Gameplay.Setting.Setting, SettingPair>
    {
    }
}