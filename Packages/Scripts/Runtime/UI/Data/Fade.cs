using System;
using UnityEngine;

namespace Enpiech.Core.Runtime.UI.Data
{
    [Serializable]
    public class Fade
    {
        [SerializeField]
        private bool _isFadeIn;

        [SerializeField]
        private float _duration;

        [SerializeField]
        private Color _color;

        public Fade(bool isFadeIn, float duration, Color color)
        {
            _isFadeIn = isFadeIn;
            _duration = duration;
            _color = color;
        }

        public bool IsFadeIn => _isFadeIn;

        public float Duration => _duration;

        public Color Color => _color;

        public static Fade In(float duration)
        {
            return new Fade(true, duration, Color.clear);
        }

        public static Fade Out(float duration)
        {
            return new Fade(false, duration, Color.black);
        }
    }
}