using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{   
    [HideInInspector]
    public GameObject currentSpawnObject;
    public void GetObjectToSpawn(GameObject objectToSpawn)
    {
        currentSpawnObject = objectToSpawn;
    }
    public void ClearObjectToSpawn()
    {
        currentSpawnObject = null;
    }
    public bool SpawnCheck()
    {
        return true;
    }
    public void Spawn()
    {

    }
    private void Update()
    {
        
    }
    private void SelectUI()
    {

    }
}
