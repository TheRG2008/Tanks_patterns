using CommonClasses;
using EventHandlers;
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
       //     tank.TankFire = new TankFire(tank.GetComponentInChildren<FirePoint>().transform.position,Vector2.zero);// find gun position
            return tank;
        }
        
        public void OnCollisionEnter(Collision other)
        {
            if (TryGetComponent<BulletMarker>(out var bullet) && !_AI)
            {
                //TURN OVER
                //     TankFire.Fire();
            }
            else
            {
                TankFire.Fire();
                Debug.Log("AUTOFIRE");
                
            }
        }
        
        public void DependencyHp(Health hp) => Health = hp;
    }
}