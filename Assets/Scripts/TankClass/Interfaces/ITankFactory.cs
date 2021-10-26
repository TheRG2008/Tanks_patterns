using CommonClasses;
using UnityEngine;

namespace TankClass.Factory.Interface
{
    public interface ITankFactory
    {
        public TankClass Create(Health heath, Vector2 position, Color color);
    }
}