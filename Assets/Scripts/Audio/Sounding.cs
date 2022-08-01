using System.Collections.Generic;
using UnityEngine;

namespace StayFast
{
    public static class Sounding
    {
        private static Dictionary<ClipType, AudioSource> audioDictionary;

        public static void Init(Dictionary<ClipType, AudioSource> dictionary)
        {
            audioDictionary = dictionary;
        }
        
        
        public static void PlayAudio(ClipType type)
        {
            var sound = audioDictionary[type];
            sound.enabled = true;
            sound.Play();
        }

        public static void StopAudio(ClipType type)
        {
            var sound = audioDictionary[type];
            sound.enabled = false;
            sound.Stop();
        }
    }
}