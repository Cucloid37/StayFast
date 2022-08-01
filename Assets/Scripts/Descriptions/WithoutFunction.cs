using UnityEngine;

namespace StayFast
{
    [CreateAssetMenu(menuName = "Object", fileName = "Descriptions/Object")]
    public class WithoutFunction : ScriptableObject
    {
        [SerializeField] private string path;
    }
}