using Core.Gameplay.Setting.AtomGenerated.EventReferences;
using Core.Gameplay.Setting.AtomGenerated.Events;
using Core.Gameplay.Setting.AtomGenerated.Pairs;
using Core.Gameplay.Setting.AtomGenerated.UnityEvents;
using UnityAtoms;
using UnityEngine;

namespace Core.Gameplay.Setting.AtomGenerated.EventReferenceListeners
{
    /// <summary>
    ///     Event Reference Listener of type `SettingPair`. Inherits from `AtomEventReferenceListener&lt;SettingPair,
    ///     SettingPairEvent, SettingPairEventReference, SettingPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/SettingPair Event Reference Listener")]
    public sealed class SettingPairEventReferenceListener : AtomEventReferenceListener<
        SettingPair,
        SettingPairEvent,
        SettingPairEventReference,
        SettingPairUnityEvent>
    {
    }
}