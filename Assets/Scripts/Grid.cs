using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : BaseGrid
{
    public GameObject middleObject;
    public GameObject gridObject;
    public Material onMouseMat;
    public Transform spawnArea;
    public bool hasObject;
    public Vector3 gridPos;

    protected Material[] starterMats;

    public override void Initialize(Vector3 pos)
    {
        gridPos = pos;
        starterMats = middleObject.GetComponent<MeshRenderer>().sharedMaterials;
    }

    public override void AddObject(GameObject gridGameObject)
    {
        gridObject = gridGameObject;
        hasObject = true;
    }

    public override void RemoveObject()
    {
        gridObject = null;
        hasObject = false;
    }

    public override void OnMouseEnter()
    {
        MouseOverGrid();
    }

    public override void OnMouseExit()
    {
        MouseIsAway();
    }

    public override void MouseOverGrid()
    {
        Material[] mats = middleObject.GetComponent<MeshRenderer>().sharedMaterials;
        mats[0] = onMouseMat;
        middleObject.GetComponent<MeshRenderer>().sharedMaterials = mats;
    }

    public override void MouseIsAway()
    {
        Material[] mats = middleObject.GetComponent<MeshRenderer>().sharedMaterials;
        mats = starterMats;
        middleObject.GetComponent<MeshRenderer>().sharedMaterials = mats;
    }
}

