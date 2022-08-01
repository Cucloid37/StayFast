using System.IO;
using UnityEngine;

namespace StayFast
{
    public static class Loader
    {
        public static T Load<T>(string resourcePath) where T : Object =>
            Resources.Load<T>(Path.ChangeExtension(resourcePath, null));
    }
}