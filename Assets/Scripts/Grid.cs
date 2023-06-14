using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    #region Params
    public GameObject middleObject;
    public GameObject gridObject;
    public Material onMouseMat;
    public Transform spawnArea;
    [HideInInspector]
    public bool hasObject;
    [HideInInspector]
    public Vector3 gridPos;
    [SerializeField]
    private Material[] starterMats;
    private bool isMouseOver;
    #endregion
    #region Methods
    public void Initialize(Vector3 pos)
    {
        gridPos = pos;
        starterMats = middleObject.GetComponent<MeshRenderer>().sharedMaterials;
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
    private void OnMouseEnter()
    {
        MouseOverGrid();
    }

    private void OnMouseExit()
    {
        MouseIsAway();
    }
    public void MouseOverGrid()
    {
        if (isMouseOver)
            return;
        isMouseOver = true;

        Material[] mats = middleObject.GetComponent<MeshRenderer>().sharedMaterials;
        mats[0] = onMouseMat;
        middleObject.GetComponent<MeshRenderer>().sharedMaterials = mats;

    }
    public void MouseIsAway()
    {
        if (!isMouseOver)
            return;

        Material[] mats = middleObject.GetComponent<MeshRenderer>().sharedMaterials;
        mats = starterMats;
        middleObject.GetComponent<MeshRenderer>().sharedMaterials = mats;
        isMouseOver = false;
    }
    #endregion
}
