using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace StayFast
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class MessageView : MonoBehaviour
    {
        
        private Transform _transform;
        public SpriteRenderer render;

        public Transform position => _transform;

        // public Animator animator => _animator;

        private void Start()
        {

            _transform = gameObject.transform;
            
        }

        public void SetSprite(Sprite sprite)
        {
            render.sprite = sprite;
        }
    }
}