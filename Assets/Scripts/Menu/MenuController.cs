using System;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace StayFast
{
    public class MenuController : BaseController, IDisposable
    {
        private MenuView _view;

        private SoundLocator _sound;

        private bool isPaused;

        public MenuController(MenuView view, InputController input, MonoFactory factory, SoundLocator sound)
        {
            _view = view;
            _sound = sound;
            
            input.OnClickESC += OnClickPaused;
            _view.Resume.onClick.AddListener(OnClickPaused);
            _view.AboutUs.onClick.AddListener(OnClickAboutUs);
            _view.Restart.onClick.AddListener(Restart);
            _view.CloseAbout.onClick.AddListener(CloseAbout);
            _view.CloseAbout.gameObject.SetActive(false);
        }

        private void Restart()
        {
            // todo
            Debug.Log("Мы нажали на рестарт");
            SceneManager.LoadScene(0);
        }

        private void OnClickAboutUs()
        {

            Debug.Log($"Mы нажали на About Us");

            Sounding.PlayAudio(ClipType.Paper);
            
   
            _view.gameObject.transform.GetChild(0).gameObject.SetActive(false);
            _view.PanelAboutUs.SetActive(true);
            _view.CloseAbout.gameObject.SetActive(true);
            _view.CloseAbout.onClick.AddListener(CloseAbout);
        }

        private void CloseAbout()
        {

            Sounding.PlayAudio(ClipType.Paper);

            _view.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            _view.PanelAboutUs.SetActive(false);
            _view.CloseAbout.gameObject.SetActive(false);
        }

        public void OnClickPaused()
        {

            Debug.Log($"{isPaused}");
            Sounding.PlayAudio(ClipType.Paper);
            
            switch (isPaused)
            {
                case false:
                    Debug.Log($"Мы открываем меню");
                    OpenPauseMenu();
                    return;
                case true:
                    Debug.Log($"Мы закрываем меню");
                    ClosePauseMenu();
                    break;
            }
        }
        
        private void OpenPauseMenu()
        {
            Sounding.PlayAudio(ClipType.Paper);

            // todo возможно делаем ещё какие-то дела

            Sounding.PlayAudio(ClipType.Paper);
            
            _view.gameObject.SetActive(true);
            Time.timeScale = 0;
            isPaused = true;
            
        }
          
        private void ClosePauseMenu()
        {

            Sounding.PlayAudio(ClipType.Paper);
            

            Debug.Log("Мы зашли в закрывашку");
            _view.gameObject.SetActive(false);
            Time.timeScale = 1;
            isPaused = false;
        }

        protected override void OnDispose()
        {
            _view.Resume.onClick.RemoveAllListeners();
            _view.Restart.onClick.RemoveAllListeners();
            _view.AboutUs.onClick.RemoveAllListeners();
            _view.CloseAbout.onClick.RemoveAllListeners();
        }
    }
}