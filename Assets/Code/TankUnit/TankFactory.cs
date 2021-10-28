﻿using CommonClasses;
using Markers;
using TankUnit.Code;
using TankUnit.Interfaces;
using UnityEngine;

namespace TankUnit
{
    public class TankFactory : ITankFactory
    {
        
        public TankClass Create(Health health, Vector2 position, Color color, bool ai)
        {
            var tank = Object.Instantiate(Resources.Load<TankView>("Prefabs/CompleteTank"));
            tank.transform.position = position;
            tank.Health = health;
            tank.TankFire = new TankFire(tank.GetComponentInChildren<FirePoint>().transform.position, Vector2.zero); // INSERT NORMAL!
            tank.TankControl = new TankController(new TankModel(color, 1),tank, ai);
            return tank;
        }  

    }
}