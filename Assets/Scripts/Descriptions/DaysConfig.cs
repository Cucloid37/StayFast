using System.Collections.Generic;
using UnityEngine;

namespace StayFast
{
    [CreateAssetMenu(fileName = "DaysConfig", menuName = "Descriptions/DaysConfig")]
    public class DaysConfig : ScriptableObject, IDaysConfigs
    {
        [SerializeField] private string[] tubePaths;
        [SerializeField] private string[] massagePaths;

        private Stack<Sprite> tubeSprites;
        private Stack<Sprite> massageSprites;


        public Stack<Sprite> TubeSprite
        {
            get
            {
                if(tubeSprites == null)
                    tubeSprites = GetSprites(tubePaths);
                return tubeSprites;
            }
        }

        public Stack<Sprite> MassageSprite
        {
            get
            {
                if (massageSprites == null)
                    massageSprites = GetSprites(massagePaths);
                return massageSprites;
            }
        }

        public Stack<Sprite> GetSprites(string[] paths)
        {
            var stack = new Stack<Sprite>();
            foreach (var path in paths)
            {
                stack.Push(Loader.Load<Sprite>(path));
            }
            return stack;
        }
    }
}