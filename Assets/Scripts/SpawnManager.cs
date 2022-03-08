using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] _fuits;
    private void Start()
    {
        InvokeRepeating("FruitsSpawner", 1, 10);
    }
    private void FruitsSpawner()
    {
        Instantiate(_fuits[0], new Vector2(Random.Range(-12, 12), Random.Range(-4, 4)), Quaternion.identity);
        Instantiate(_fuits[1], new Vector2(Random.Range(-12, 12), Random.Range(-4, 4)), Quaternion.identity);
        Instantiate(_fuits[2], new Vector2(Random.Range(-12, 12), Random.Range(-4, 4)), Quaternion.identity);
    }
}
