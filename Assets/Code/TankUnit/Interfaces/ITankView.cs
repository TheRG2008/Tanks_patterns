using UnityEngine;

namespace TankUnit.Interfaces
{
    public interface ITankView
    {
        Transform Transform { get; set; }

        delegate void Damaged();

        event Damaged GETNext;
        public bool AI {get; set; }

        public bool Firstblood { get; set; }
    }
}