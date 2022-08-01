using System;
using UnityEngine;

namespace StayFast
{
    public class NightView : MonoBehaviour
    {
        public event Action OnEndNight;

        public Animator Sleeping;

        private void Awake()
        {
            Sleeping = gameObject.GetComponent<Animator>();
            Sleeping.enabled = false;
        }


        public void EndNight()
        {
            Debug.Log("Мы сделали это!");
            OnEndNight?.Invoke();
        }
        
        
    }
}