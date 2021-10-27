using CommonClasses;
using EventHandlers;
using JetBrains.Annotations;
using TankClass.Code;
using TankClass.Interfaces;
using UnityEngine;

namespace TankClass
{
    public class TankFactory : ITankFactory
    {
        private ITankControl _tankControl;
        private ITankFire _tankFire;
        public FireEvent fireEvent;

        public Code.TankClass Create(Health health, Vector2 position, Color color, bool AI)
        {
            var tank = Object.Instantiate(Resources.Load<TankView>("Prefabs/CompleteTank"));
            tank.transform.position = position;
            tank.Health = health;
            _tankFire = new TankFire(Vector2.zero);// find gun position
            _tankControl = new TankController(new TankModel(color, 1),tank);
           if(AI) fireEvent.startTurn += () => _tankFire.Fire();
            return tank;
        }  

    }
}