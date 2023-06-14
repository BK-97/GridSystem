using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{   
    [HideInInspector]
    public GameObject currentSpawnObject;

    public static ObjectManager Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }
    public GameObject GetSelectedPrefab()
    {
        return currentSpawnObject;
    }
    public void SetSelectedPrefab(GameObject prefab)
    {
        currentSpawnObject = prefab;
    }
    public void ClearObjectToSpawn()
    {
        currentSpawnObject = null;
    }
}
