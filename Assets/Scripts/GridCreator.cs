using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridCreator : MonoBehaviour
{
    [SerializeField]
    private int gridMapHeight=1;
    [SerializeField]
    private int gridMapWidth=1;
    [SerializeField]
    private GameObject gridPrefab;

    private void Start()
    {
        CreateGrid();
    }
    public void CreateGrid()
    {
        DeleteChildGrids();
        Vector3 creatorPosition = transform.position;

        float offsetX = (gridMapWidth - 1) * 0.5f;
        float offsetZ = (gridMapHeight - 1) * 0.5f;

        if (gridMapWidth % 2 == 1)
            creatorPosition.x += 0.5f;
        if(gridMapHeight%2==1)
            creatorPosition.z += 0.5f;
        for (int row = 0; row < gridMapHeight; row++)
        {
            for (int col = 0; col < gridMapWidth; col++)
            {
                Vector3 offset = new Vector3(col - offsetX, 0, row - offsetZ);
                Vector3 position = creatorPosition + offset;
                GameObject gridObject = Instantiate(gridPrefab, position, Quaternion.identity);
                gridObject.transform.SetParent(transform);
                Grid grid = gridObject.GetComponent<Grid>();
                grid.Initialize(position);
            }
        }
    }
    private void DeleteChildGrids()
    {
        for (int i = transform.childCount-1; i >= 0; i--)
        {
#if UNITY_EDITOR
            DestroyImmediate(transform.GetChild(i).gameObject);
#else
            Destroy(transform.GetChild(i).gameObject);
#endif
        }
    }

}
