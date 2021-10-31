using CommonClasses;
using TankUnit.Interfaces;
using UnityEngine;
using UnityEngine.Serialization;

namespace TankUnit.Code
{
    public abstract class TankClass : MonoBehaviour
    {
        public static TankView TankView;
        public ITankFire TankFire;
        public ITankControl TankControl;
        [FormerlySerializedAs("II")] public bool ii;
        
       public Health Health { get; set; }
    }
}