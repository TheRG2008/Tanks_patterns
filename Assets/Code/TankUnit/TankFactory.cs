using CommonClasses;
using Markers;
using TankUnit.Code;
using TankUnit.Interfaces;
using UnityEngine;
using Weapon;
using UnityEngine;


namespace TankUnit
{
    public class TankFactory : MonoBehaviour,ITankFactory
    {
        

        public TankClass Create(Health health, Vector3 position, Color color, Quaternion rotation, bool ai)

        {
            var tank = Object.Instantiate(Resources.Load<TankView>("Prefabs/CompleteTank"));
            tank.transform.position = position;
            tank.Health = health;
            tank.TankFire = new TankFire(tank.GetComponentInChildren<FirePoint>().transform.position, tank.GetComponentInChildren<Cannon>()); // INSERT NORMAL!
            tank.TankControl = new TankController(new TankModel(color, 1),tank, ai);
            tank.transform.rotation = rotation;
            Debug.Log($"{rotation}");
            if (ai) tank.transform.LookAt(rotation.eulerAngles);

            return tank;
        }  

    }
}