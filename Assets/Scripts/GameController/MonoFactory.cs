using UnityEngine;

namespace StayFast
{
    public class MonoFactory : MonoBehaviour
    {
        public GameObject Instant(GameObject descriptionPrefab, Transform _transform)
        {
            return Instantiate(descriptionPrefab, _transform);
        }
    }
}