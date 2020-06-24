using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    
    public List<GameObject> SpawnObjects;

    private float spawntime = 1f;
    public Transform[] spawningPosition;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawner", spawntime, spawntime); 
    }
    void spawner()
    {
        int spawnerX = Random.Range(-4, 4);
        Vector3 SpawnPosition = new Vector3(spawnerX, 0, 0);
        Instantiate(SpawnObjects[spawnerX], SpawnPosition, Quaternion.identity);
    }
    
}
