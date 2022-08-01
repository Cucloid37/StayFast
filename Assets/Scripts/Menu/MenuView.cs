using System;
using UnityEngine;
using UnityEngine.UI;

namespace StayFast
{
    public class MenuView : MonoBehaviour
    {
        [SerializeField] private Scrollbar _scrollbar;
        private Button _aboutUs;
        private Button _resume;
        private Button _restart;
        private Button _closeAbout;
        private GameObject _panelAboutUs;

        public Button AboutUs => _aboutUs;
        public Button Resume => _resume;
        public Button Restart => _restart;
        public Button CloseAbout => _closeAbout;
        public GameObject PanelAboutUs => _panelAboutUs;
        
        private void Awake()
        {
            AudioListener.volume = _scrollbar.value;
            _panelAboutUs = transform.GetChild(1).gameObject;
            _panelAboutUs.SetActive(false);
            _aboutUs = transform.GetChild(0).GetChild(1).GetComponent<Button>();
            _restart = transform.GetChild(0).GetChild(2).GetComponent<Button>();
            _resume = transform.GetChild(0).GetChild(3).GetComponent<Button>();
            _closeAbout = _panelAboutUs.transform.GetChild(1).GetComponent<Button>();
            _scrollbar = GetComponentInChildren<Scrollbar>();
            
        }
        
        
    }
}