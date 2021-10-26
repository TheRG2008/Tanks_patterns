using CommonClasses;
using TankClass.Controller;
using TankClass.Controller.Interface;
using TankClass.Factory.Interface;
using TankClass.Model;
using TankClass.View;
using UnityEngine;

namespace TankClass.Factory
{
    public class TankFactory : ITankFactory
    {
        private ITankControl _tankControl;

        public TankClass Create(Health health, Vector2 position, Color color)
        {
            var tank = Object.Instantiate(Resources.Load<TankView>("Assets/_Completed-Assets/Prefabs/CompleteTank.prefab"));
            tank.transform.position = position;
            _tankControl = new TankController(new TankModel(color, 1),tank);
            return tank;
        }     

    }
}