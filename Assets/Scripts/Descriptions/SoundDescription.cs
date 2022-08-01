using UnityEngine;

namespace StayFast
{
    [CreateAssetMenu(fileName = "Sound", menuName = "Descriptions/Sound")]
    public class SoundDescription : ScriptableObject
    {
        [SerializeField] private AudioSource music;
    }
}