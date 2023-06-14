using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    [SerializeField]
    private InputManager inputManager;
    //[HideInInspector]
    public Grid currentGrid;

    [SerializeField]
    private LayerMask gridLayerMask;

    private void Update()
    {
        Grid gridGet = GetMouseOverGrid();
        if (gridGet != null)
            currentGrid = gridGet;
        else
            currentGrid = null;
    }
    private void OnEnable()
    {
        InputManager.OnClick.AddListener(ClickOn);
    }
    private void OnDisable()
    {
        InputManager.OnClick.RemoveListener(ClickOn);
    }
    private bool CheckIfGrid()
    {
        if (currentGrid == null)
            return false;
        else
            return true;
    }
    private void ClickOn()
    {
        if (ObjectManager.Instance.currentSpawnObject == null)
            return;

        if (CheckIfGrid())
        {
            if (currentGrid.hasObject)
            {
                Debug.Log("Grid is NOT empty");
            }
            else
            {
                Debug.Log("Grid is empty");
                CreateObject(currentGrid);
            }
        }
        else
        {
            Debug.Log("Spawn Object Reset");
            ObjectManager.Instance.ClearObjectToSpawn();
        }
    }
    private void CreateObject(Grid parentGrid)
    {
        var go=Instantiate(ObjectManager.Instance.currentSpawnObject,parentGrid.spawnArea);
        parentGrid.AddObject(go);
    }
    public Grid GetMouseOverGrid()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane;

        Ray ray = Camera.main.ScreenPointToRay(mousePos);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100, gridLayerMask))
        {
            if (hit.collider.gameObject.GetComponent<Grid>() != null)
                return hit.collider.gameObject.GetComponent<Grid>();
            else
                return null;
        }
        return null;
    }
}
