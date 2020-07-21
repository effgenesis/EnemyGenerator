using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _defaultEnemyPrefab;
    public void SpawnEnemy()
    {
        Instantiate(_defaultEnemyPrefab, transform.position, Quaternion.identity);
    }
}
