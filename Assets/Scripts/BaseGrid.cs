using UnityEngine;
public abstract class BaseGrid : MonoBehaviour
{
    public abstract void Initialize(Vector3 pos);
    public abstract void AddObject(GameObject gridGameObject);
    public abstract void RemoveObject();
    public abstract void OnMouseEnter();
    public abstract void OnMouseExit();
    public abstract void MouseOverGrid();
    public abstract void MouseIsAway();
}