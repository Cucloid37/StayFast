using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StayFast
{
    public class GlobalDaysController : BaseController
    {
        private readonly ChangeDaysController _daysController;
        private readonly SoundLocator _soundLocator;


        private Stack<Sprite> tubeStack;
        private Stack<Sprite> massageStack;
        private CoroutineSystem _coroutine;

        private int dayLenght = 20;

        public GlobalDaysController(AllDescriptions descriptions, CoroutineSystem coroutine, ChangeDaysController daysController)
        {
            tubeStack = descriptions.DaysConfig.TubeSprite;
            massageStack = descriptions.DaysConfig.MassageSprite;

            _soundLocator = descriptions.SoundLocator;

            _coroutine = coroutine;
            
            _daysController = daysController;
        }

        public IEnumerator Timer()
        {
            int count = 0;

            while (count < dayLenght)
            {
                yield return new WaitForSeconds(1);
                count++;
                Debug.Log($"Прошло секунд {count}");
                // todo здесь отображаем время на UI
            }

            dayLenght += 8;
            
            //_soundLocator.StopAudio(ClipType.Soft);
            
            GameObject.FindGameObjectWithTag("qwe").GetComponent<MainMechanic>().AnimationStop();

            Sounding.StopAudio(ClipType.Soft);
            //MainMechanic.AnimationStop();


            var tube = tubeStack.Pop();
            var massage = massageStack.Peek();

            _coroutine.Starting(_daysController.ChangeDays(tube, massage));
        }

        public void TestVoid()
        {
            
        }
    }
}