using CommonClasses;
using UnityEngine;

namespace TankClass.Code
{
    public abstract class TankClass : MonoBehaviour
    {
        public static TankView TankView;
        public Health Health { get; set; }

        public static TankView CreateTank(Health health, Vector2 position)
        {
            var tank = Resources.Load<TankView>("_Completed-Assets/Prefabs/CompleteTank");
            tank.Health = health;
            return tank;
        }
        
        public void DependencyHp(Health hp) => Health = hp;
    }
}