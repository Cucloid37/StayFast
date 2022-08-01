using System;
using UnityEngine.Windows;
using Input = UnityEngine.Input;

namespace StayFast
{
    public class InputController : IExecute
    {
        public event Action OnClickESC;
        public event Action OnLeftMouseDown;

        private readonly InputKeys _keys;
        // private readonly InputKeysData _inputKeysData;
        
        public InputController()
        {
            _keys = new InputKeys();
        }

        public void Execute(float deltaTime)
        {
            _keys.GetESC(OnClickESC);
            _keys.GetMouseLeft(OnLeftMouseDown);
        }
    }
    
}