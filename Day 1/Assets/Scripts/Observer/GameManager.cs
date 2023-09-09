using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using System;
public class GameManager : MonoBehaviour 
{
    public static event Action onSpacePressed;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            onSpacePressed?.Invoke();
        }
    }
}
