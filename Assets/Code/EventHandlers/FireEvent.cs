using System.Collections.Generic;
using TankUnit.Code;
using UnityEngine;

namespace EventHandlers
{
    public class FireEvent
    {
        private bool _isTurnOver = true;
        private List<TankClass> _tankList = new List<TankClass>();
        public  FireEvent(List<TankClass> tanks)
        {
            _tankList = tanks;
            Debug.Log($"Got {tanks.Count} tanks and have {_tankList.Count} in handler");
        }

        public void Fire()
        {
            if (!_isTurnOver) return;
            _tankList[0].TankFire.Fire();

        }
        
    }
}