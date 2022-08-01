using System;
using UnityEngine;

namespace StayFast
{
    [Serializable]
    public class SoundDescript
    {
        [SerializeField] public AudioSource clip;

        [SerializeField] public ClipType type;
    }
}