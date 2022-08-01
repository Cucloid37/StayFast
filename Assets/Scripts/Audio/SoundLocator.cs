using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StayFast
{
    public class SoundLocator : MonoBehaviour
    {
        [SerializeField] private SoundDescript[] allSound;

        private Dictionary<ClipType, AudioSource> audioDictionary = new Dictionary<ClipType, AudioSource>();

        public Dictionary<ClipType, AudioSource> AudioDictionary => audioDictionary;

        public void Init()
        {
            foreach (var sound in allSound)
            {
                audioDictionary.Add(sound.type, sound.clip);
            }
        }

        /*
        public void PlayAudio(ClipType type)
        {
            var sound = audioDictionary[type];
           // sound.enabled = true;
            sound.Play();
        }

        public void StopAudio(ClipType type)
        {
            var sound = audioDictionary[type];
            //sound.enabled = false;
            sound.Stop();
        }
        */


    }
}