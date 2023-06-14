using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ButtonCreateInfo : MonoBehaviour
{
    public GameObject spawnPrefab;

    private TextMeshProUGUI textMesh;
    private void Start()
    {
        textMesh = GetComponentInChildren<TextMeshProUGUI>();
        textMesh.text = spawnPrefab.name;
    }
    public void GiveSpawnPrefabInfo()
    {
        ObjectManager.Instance.SetSelectedPrefab(spawnPrefab);
    }
}
