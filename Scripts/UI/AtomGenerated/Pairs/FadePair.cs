using System;
using Core.UI.Data;
using UnityAtoms;
using UnityEngine;

namespace Core.UI.AtomGenerated.Pairs
{
    /// <summary>
    ///     IPair of type `&lt;Fade&gt;`. Inherits from `IPair&lt;Fade&gt;`.
    /// </summary>
    [Serializable]
    public struct FadePair : IPair<Fade>
    {
        [SerializeField]
        private Fade _item1;

        [SerializeField]
        private Fade _item2;

        public Fade Item1
        {
            get => _item1;
            set => _item1 = value;
        }

        public Fade Item2
        {
            get => _item2;
            set => _item2 = value;
        }

        public void Deconstruct(out Fade item1, out Fade item2)
        {
            item1 = Item1;
            item2 = Item2;
        }
    }
}