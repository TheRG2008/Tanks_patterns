using System.Collections.Generic;
using TankUnit.Code;
using UnityEngine;

namespace EventHandlers
{
    public class FireEvent
    {
        private bool _isTurnOver = false;
        public int Counter = 0;
        private readonly List<TankClass> _tankList;
        public  FireEvent(List<TankClass> tanks)
        {
            _tankList = tanks;

            foreach (var tank in _tankList)
            {
                tank.TankControl.MoveIt += () =>
                {
                    Debug.Log($"next is {Counter}");
                    Counter++;
                    Fire();
                };
            }

        }

        public void Fire()
        {
            if (_isTurnOver) return;
//            Debug.Log($"shot from {choose_next()}");
            _tankList[choose_next()].TankFire.Fire();

        }

        private int choose_next()
        {
            if (Counter == _tankList.Count)
            {
                _isTurnOver = true;
                NewTurn(_tankList);
                return 0;
            }
            return Counter;
        }

        private void NewTurn(List<TankClass> tanklist)
        {
            foreach (var tank in tanklist)
            {
                tank.TankFire.Fired = false;
            }
        }
        
    }
}