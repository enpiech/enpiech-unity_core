#if UNITY_2019_1_OR_NEWER
using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.Events;
using Enpiech.Core.Runtime.Gameplay.Save.AtomGenerated.Pairs;
using UnityAtoms.Editor;
using UnityEditor;

namespace Enpiech.Core.Editor.Gameplay.Save.AtomGenerated.AtomEditors.Events
{
    /// <summary>
    ///     Event property drawer of type `SavePair`. Inherits from `AtomEventEditor&lt;SavePair, SavePairEvent&gt;`. Only
    ///     availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(SavePairEvent))]
    public sealed class SavePairEventEditor : AtomEventEditor<SavePair, SavePairEvent>
    {
    }
}
#endif