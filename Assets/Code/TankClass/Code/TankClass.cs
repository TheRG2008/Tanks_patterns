using CommonClasses;
using Markers;
using TankClass.Interfaces;
using UnityEngine;

namespace TankClass.Code
{
    public abstract class TankClass : MonoBehaviour
    {
        public static TankView TankView;
        public ITankFire TankFire;
        public static bool _AI;
        public Health Health { get; set; }

        public static TankView CreateTank(Health health, Vector2 position, bool ai)
        {
            var tank = Resources.Load<TankView>("_Completed-Assets/Prefabs/CompleteTank");
            tank.Health = health;
            _AI = ai;
         //   tank.TankFire = new TankFire(Vector2.zero);// find gun position
            return tank;
        }
        
        public void OnCollisionEnter(Collision other)
        {
            if (TryGetComponent<BulletMarker>(out var bullet) && !_AI)
            {
           //     TankFire.Fire();
            }
            else
            {
                Debug.Log("AutoFire");
            }
        }
        
        public void DependencyHp(Health hp) => Health = hp;
    }
}