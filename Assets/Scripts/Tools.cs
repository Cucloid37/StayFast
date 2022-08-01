using UnityEngine;

namespace StayFast
{
    public static class Tools
    {
        public static T GetOrAddComponent<T>(GameObject go) where T : Component
        {
            if (go.GetComponent<T>() == null)
                return go.AddComponent<T>();
            return go.GetComponent<T>();
        }
    }
}