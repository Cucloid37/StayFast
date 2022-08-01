using System.Collections.Generic;
using UnityEngine;

namespace StayFast
{
    public interface IDaysConfigs : IConfig
    {
        Stack<Sprite> TubeSprite { get; }
        Stack<Sprite> MassageSprite { get; }
        
    }

    public interface IConfig
    {
        
    }
}