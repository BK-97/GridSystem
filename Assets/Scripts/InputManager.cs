using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    #region Events
    public static UnityEvent OnClick = new UnityEvent();
    #endregion


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OnClick.Invoke();
        }
    }
}
