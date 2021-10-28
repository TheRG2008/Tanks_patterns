using CommonClasses;
using TankUnit.Code;
using UnityEngine;

namespace TankUnit.Interfaces
{
    public interface ITankFactory
    {
        public TankClass Create(Health heath, Vector2 position, Color color, bool ai);
    }
}