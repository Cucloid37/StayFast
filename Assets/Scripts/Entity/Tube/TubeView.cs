using System;
using UnityEngine;

namespace StayFast
{
    public class TubeView : MonoBehaviour
    {
        private SpriteRenderer _render;
        private Sprite _sprite;

        private void Awake()
        {
            _render = gameObject.GetComponent<SpriteRenderer>();
            _sprite = _render.sprite;
        }

        public void SetSprite(Sprite sprite)
        {
            _sprite = sprite;
        }
    }
}