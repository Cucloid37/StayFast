using System.Collections;
using UnityEngine;

namespace StayFast
{
    public class CoroutineSystem : MonoBehaviour
    {
        public void Starting(IEnumerator method)
        {
            StartCoroutine(method);
        }

        public void StopAllCoroutine()
        {
            StopAllCoroutines();
        }
    }
}