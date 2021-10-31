using CommonClasses;
using Markers;
using TankUnit.Code;
using TankUnit.Interfaces;
using UnityEngine;
using Weapon;

namespace TankUnit
{
    public class TankFactory : ITankFactory
    {
        

        public TankClass Create(Health health, Vector3 position, Color color, Transform rotation, bool ai)

        {
            var tank = Object.Instantiate(Resources.Load<TankView>("Prefabs/CompleteTank"));
            tank.transform.position = position;
            tank.Health = health;
            tank.AI = ai;
            tank.TankControl = new TankController(new TankModel(color, 1),tank, ai);
            tank.TankFire = new TankFire(tank.GetComponentInChildren<FirePoint>().transform.position, tank.GetComponentInChildren<Cannon>(),tank);
           if (ai)
            {
                tank.transform.LookAt(rotation.position);
            }
            else
            {
                tank.transform.rotation = rotation.rotation;
            }
            return tank;
        }  

    }
}