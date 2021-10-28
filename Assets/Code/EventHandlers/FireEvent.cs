using System.Collections.Generic;
using TankUnit.Code;
using UnityEngine;

namespace EventHandlers
{
    public class FireEvent
    {
        private bool _isTurnOver = true;
        private readonly List<TankClass> _tankList;
        public  FireEvent(List<TankClass> tanks)
        {
            _tankList = tanks;
        }

        public void Fire()
        {
            if (!_isTurnOver) return;
            _tankList[0].TankFire.Fire();

        }
        
    }
}