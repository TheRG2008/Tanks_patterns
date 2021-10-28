using CommonClasses;
using TankUnit.Code;
using UnityEngine;

namespace TankUnit.Interfaces
{
    public interface ITankFactory
    {

        public TankClass Create(Health heath, Vector3 position, Color color, Quaternion rotation, bool ai);

    }
}