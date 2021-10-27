using CommonClasses;
using Markers;
using UnityEngine;

namespace TankClass.Code
{
    public abstract class TankClass : MonoBehaviour
    {
        public static TankView TankView;

        public bool player;
        public Health Health { get; set; }

        public static TankView CreateTank(Health health, Vector2 position)
        {
            var tank = Resources.Load<TankView>("_Completed-Assets/Prefabs/CompleteTank");
            tank.Health = health;
            return tank;
        }
        
        public void OnCollisionEnter(Collision other)
        {
            if (other.GetType() == typeof(BulletMarker) && player)
            {
                Debug.Log("It hurts");
            }
            else
            {
                Debug.Log("AutoFire");
            }
        }
        
        public void DependencyHp(Health hp) => Health = hp;
    }
}