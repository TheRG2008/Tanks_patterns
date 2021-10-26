using System;
using System.Linq;
using CommonClasses;
using DefaultNamespace.Markers;
using TankClass.Factory;
using TankClass.Factory.Interface;
using UnityEngine;

namespace DefaultNamespace
{
    public class GameStarter : MonoBehaviour
    {
        private ITankFactory _tankFactory;
        private SpawnPoint[] _spawnPoints;

        private void Start()
        {
            _spawnPoints = FindObjectsOfType<SpawnPoint>();
            
            _tankFactory = new TankFactory();
            _tankFactory.Create(new Health(100.0f, 100.0f), _spawnPoints[0].transform.position, Color.red);
        }
    }
}