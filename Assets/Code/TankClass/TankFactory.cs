using CommonClasses;
using EventHandlers;
using JetBrains.Annotations;
using Markers;
using TankClass.Code;
using TankClass.Interfaces;
using UnityEngine;

namespace TankClass
{
    public class TankFactory : ITankFactory
    {
        private ITankControl _tankControl;
       
        public Code.TankClass Create(Health health, Vector2 position, Color color, bool AI)
        {
            
            var tank = Object.Instantiate(Resources.Load<TankView>("Prefabs/CompleteTank"));
            tank.transform.position = position;
            tank.Health = health;
            tank.TankFire = new TankFire(tank.GetComponentInChildren<FirePoint>().transform.position, Vector2.zero); // INSERT NORMAL!
            _tankControl = new TankController(new TankModel(color, 1),tank);
           return tank;
        }  

    }
}