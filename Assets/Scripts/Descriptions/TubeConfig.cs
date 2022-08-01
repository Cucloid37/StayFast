using UnityEngine;

namespace StayFast
{
    [CreateAssetMenu(fileName = "Tube", menuName = "Descriptions/Tube")]
    public class TubeConfig : ScriptableObject
    {
        [SerializeField] private string tubePath;

        private TubeView tubeView;
        
        public TubeView TubeView
        {
            get
            {
                if (tubeView == null)
                {
                    tubeView = Loader.Load<TubeView>(tubePath);
                }

                return tubeView;
            }
        }
    }
}