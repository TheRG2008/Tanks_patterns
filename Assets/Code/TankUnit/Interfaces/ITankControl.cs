using UnityEngine;

namespace TankUnit.Interfaces
{
    public interface ITankControl
    {
        void RotateTo(Transform transform);
        void NewTurn();
    }
}