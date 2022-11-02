using Core.UI.AtomGenerated.Pairs;
using Core.UI.AtomGenerated.Variables;
using Core.UI.Data;
using UnityAtoms.Editor;
using UnityEditor;

namespace Core.UI.AtomGenerated.Editor.AtomEditors.Variables
{
    /// <summary>
    ///     Variable Inspector of type `Fade`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(FadeVariable))]
    public sealed class FadeVariableEditor : AtomVariableEditor<Fade, FadePair>
    {
    }
}