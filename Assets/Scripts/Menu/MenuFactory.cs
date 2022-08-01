using UnityEngine;

namespace StayFast
{
    public class MenuFactory
    {

        private readonly MonoFactory instantiate;
        private readonly Transform canvas;

        public MenuFactory(MonoFactory instantiate, Transform canvas)
        {
            this.instantiate = instantiate;
            this.canvas = canvas;
        }

        public MenuView CreateMenu()
        {
            var go = Loader.Load<GameObject>("Prefabs/UI/PauseMenu");
            var instant = instantiate.Instant(go, canvas);
            var view = instant.GetComponent<MenuView>();
            instant.SetActive(false);
            return view;
        }
    }
}