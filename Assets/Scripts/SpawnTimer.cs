using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class SpawnTimer : MonoBehaviour
{
    [SerializeField] private Spawner[] _spawners = new Spawner[4];
    private static float _spawnPeriod = 2f;
    private float _spawnTimer = _spawnPeriod;
    private int _currentSpawnPoint;
    [SerializeField] private UnityEvent _spawnEnemy;
    
    private void Update()
    {
        _spawnTimer -= Time.deltaTime;
        if (_spawnTimer <= 0)
        {
            _spawnTimer = _spawnPeriod;
            if (_spawners.Count() > 0)
            {
                _spawners[_currentSpawnPoint].SpawnEnemy();
                _currentSpawnPoint++;
                if (_currentSpawnPoint > _spawners.Count() - 1)
                {
                    _currentSpawnPoint = 0;
                }
            }
        }
    }
}
