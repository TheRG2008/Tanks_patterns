using CommonClasses;
using UnityEngine;

namespace TankClass.Interfaces
{
    public interface ITankFactory
    {
        public Code.TankClass Create(Health heath, Vector2 position, Color color);
    }
}