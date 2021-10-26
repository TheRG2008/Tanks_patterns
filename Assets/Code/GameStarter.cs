using System.Collections.Generic;
using CommonClasses;
using EventHandlers;
using Markers;
using TankClass;
using TankClass.Interfaces;
using UnityEngine;

public class GameStarter : MonoBehaviour
{
    private ITankFactory _tankFactory;
    private SpawnPoint[] _spawnPoints;
    private FireEvent _fireEvent;
    private List<TankClass.Code.TankClass> _tankList = new List<TankClass.Code.TankClass>();
    private void Start()
    {
        _spawnPoints = FindObjectsOfType<SpawnPoint>();
        _tankFactory = new TankFactory();
        SpawnTanks(_spawnPoints);
        _fireEvent = new FireEvent(_tankList);
    }


    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _fireEvent.Fire();
            Debug.Log("FIREEE");
        }
    }

    private void SpawnTanks(SpawnPoint[] spawnPoints)
    {
        foreach (var spawnPoint in  spawnPoints)
        {
           _tankList.Add(_tankFactory.Create(new Health(100.0f, 100.0f), spawnPoint.transform.position, Color.red));
        
        }
        Debug.Log($"{_tankList.Count} are here");
    }
}