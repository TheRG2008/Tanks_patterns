using CommonClasses;
using TankClass.Interface;
using TankClass.View;
using UnityEngine;

namespace TankClass
{
    public abstract class TankClass : MonoBehaviour
    {
        public static TankView TankView;
        private Health Health { get; set; }

        public static TankView CreateTank(Health health, Vector2 position)
        {
            var tank = Resources.Load<TankView>("Assets/_Completed-Assets/Prefabs/CompleteTank.prefab");
            tank.Health = health;
            return tank;
        }
        
        public void DependencyHp(Health hp) => Health = hp;
    }
}