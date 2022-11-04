using Core.AtomGenerated.Pairs;
using Core.AtomGenerated.Variables;
using UnityAtoms.Editor;
using UnityEditor;
using UnityEngine;

namespace Core.AtomGenerated.Editor.AtomEditors.Variables
{
    /// <summary>
    ///     Variable Inspector of type `Sprite`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(SpriteVariable))]
    public sealed class SpriteVariableEditor : AtomVariableEditor<Sprite, SpritePair>
    {
    }
}