using System.Collections.Generic;
using TankUnit.Code;
using UnityEngine;

namespace EventHandlers
{
    public class FireEvent
    {
        private bool _isTurnOver = false;
        private int _counter = 0;
        private readonly List<TankClass> _tankList;
        public  FireEvent(List<TankClass> tanks)
        {
            _tankList = tanks;
            foreach (var tank in _tankList)
            {
                tank.TankFire.MoveIt += AutoFire;
            }
        }
        private void AutoFire()
        {
            Debug.Log($"Next is {_counter}");
            _tankList[choose_next()].TankFire.Fire();
            _counter++;
        }
        public void Fire()
        {
            if (_isTurnOver)
            {
                if (_counter == _tankList.Count)
                {
                    NewTurn(_tankList);
                    Fire();
                }
                Debug.Log($"BAAAAD counter is {_counter} must be {_tankList.Count}");
                return;
            }
            _tankList[choose_next()].TankFire.Fire();
           _isTurnOver = true;
        }
        private int choose_next()
        {
            if (_counter != _tankList.Count)
            {
                return _counter;
            }
            return _counter;
        }
        private void NewTurn(List<TankClass> tanklist)
        {
            Debug.Log("restart");
            foreach (var tank in tanklist)
            {
                _counter = 0;
                _isTurnOver = false;
                tank.TankFire.Fired = false;
                tank.TankControl.NewTurn();
            }
        }
        
    }
}