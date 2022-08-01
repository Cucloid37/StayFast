using System;
using Unity.VisualScripting;
using UnityEngine;

namespace StayFast
{
    [CreateAssetMenu(fileName = "NightConfig", menuName = "Descriptions/NightConfig")]
    public class NightConfig : ScriptableObject
    {

        [SerializeField] public Sprite[] Bloknot;
        [SerializeField] private string nightImageString;
        [SerializeField] private string tubeString;
        [SerializeField] private string massageString;


        private TubeView tubeSprite;
        private MessageView _messageSprite;
       
        public TubeView TubeSprite => Loading<TubeView>(tubeString);

        public MessageView MessageView => Loading<MessageView>(massageString);

        public NightView NightView => Loading<NightView>(nightImageString);

        
        public static T Loading<T>(string path) where T : Component
        {
                var image = Loader.Load<GameObject>(path);
                var instant = Instantiate(image);
                instant.SetActive(false);
                var animator = instant.GetComponent<T>();
                return animator;
        }

    }
}