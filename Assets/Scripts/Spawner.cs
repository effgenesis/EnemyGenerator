using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _defaultEnemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnEnemy()
    {
        //Instantiate(_defaultEnemyPrefab, transform);
        Instantiate(_defaultEnemyPrefab, transform.position, Quaternion.identity);
    }
}
