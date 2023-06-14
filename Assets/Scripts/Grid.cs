using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public bool hasObject;
    public GameObject gridObject;
    public Vector3 gridPos;

    public void Initialize(Vector3 pos)
    {
        gridPos = pos;
    }
    public void AddObject(GameObject gridGameObject)
    {
        gridObject = gridGameObject;
        hasObject = true;
    }
    public void RemoveObject()
    {
        gridObject = null;
        hasObject = false;
    }
}
