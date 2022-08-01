using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace StayFast
{
    public class Starter : MonoBehaviour
    {
        [SerializeField] private AllDescriptions _descriptions;
        [SerializeField] private Transform _canvas;
        [SerializeField] private Button _pauseButton;
        private GameInitialization _initialization;
        private UpdateController _update;

        private void Start()
        {

            _update = new UpdateController();
            var initialization = new GameInitialization(_update, _descriptions, _canvas, _pauseButton);
        }

    
        private void Update()
        {
            _update.Execute(Time.deltaTime);
        }


    }
}

