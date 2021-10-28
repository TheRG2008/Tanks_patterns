using CommonClasses;
using TankUnit.Interfaces;
using UnityEngine;

namespace TankUnit.Code
{
    public abstract class TankClass : MonoBehaviour
    {
        public static TankView TankView;
        public ITankFire TankFire;
        public ITankControl TankControl;
        
       public Health Health { get; set; }
    }
}