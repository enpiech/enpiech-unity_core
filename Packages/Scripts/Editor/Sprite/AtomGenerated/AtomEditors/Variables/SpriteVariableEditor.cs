using Enpiech.Core.Runtime.AtomGenerated.Pairs;
using Enpiech.Core.Runtime.AtomGenerated.Variables;
using UnityAtoms.Editor;
using UnityEditor;

namespace Enpiech.Core.Editor.Sprite.AtomGenerated.AtomEditors.Variables
{
    /// <summary>
    ///     Variable Inspector of type `Sprite`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(SpriteVariable))]
    public sealed class SpriteVariableEditor : AtomVariableEditor<UnityEngine.Sprite, SpritePair>
    {
    }
}