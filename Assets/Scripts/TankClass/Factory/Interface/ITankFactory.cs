using CommonClasses;
using UnityEngine;

namespace TankClass.Interface
{
    public interface ITankFactory
    {
        public TankClass Create(Health heath, Vector2 position);
    }
}