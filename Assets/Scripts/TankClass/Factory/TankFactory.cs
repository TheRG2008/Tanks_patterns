using CommonClasses;
using TankClass.Controller.Interface;
using TankClass.Interface;
using TankClass.View;
using UnityEngine;

namespace TankClass.Factory
{
    public class TankFactory : ITankFactory
    {
        private ITankControl _tankControl;

        public TankClass Create(Health health, Vector2 position)
        {
            var tank = Object.Instantiate(Resources.Load<TankView>("Assets/_Completed-Assets/Prefabs/CompleteTank.prefab"));
            tank.transform.position = position;
            //_tankControl = new T
            return tank;
        }     

    }
}