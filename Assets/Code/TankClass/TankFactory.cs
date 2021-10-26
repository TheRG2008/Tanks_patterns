using CommonClasses;
using TankClass.Code;
using TankClass.Interfaces;
using UnityEngine;

namespace TankClass
{
    public class TankFactory : ITankFactory
    {
        private ITankControl _tankControl;

        public Code.TankClass Create(Health health, Vector2 position, Color color)
        {
            var tank = Object.Instantiate(Resources.Load<TankView>("Prefabs/CompleteTank"));
            tank.transform.position = position;
            tank.Health = health;
            _tankControl = new TankController(new TankModel(color, 1),tank);
            return tank;
        }     

    }
}