using Core.Gameplay.Setting.AtomGenerated.EventReferences;
using Core.Gameplay.Setting.AtomGenerated.Events;
using Core.Gameplay.Setting.AtomGenerated.UnityEvents;
using UnityAtoms;
using UnityEngine;

namespace Core.Gameplay.Setting.AtomGenerated.EventReferenceListeners
{
    /// <summary>
    ///     Event Reference Listener of type `Setting`. Inherits from `AtomEventReferenceListener&lt;Setting, SettingEvent,
    ///     SettingEventReference, SettingUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Setting Event Reference Listener")]
    public sealed class SettingEventReferenceListener : AtomEventReferenceListener<
        Setting,
        SettingEvent,
        SettingEventReference,
        SettingUnityEvent>
    {
    }
}