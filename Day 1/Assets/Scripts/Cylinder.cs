using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Cylinder : MonoBehaviour, IObserver
{
    private void OnEnable()
    {
        GameManager.onSpacePressed += Notify;
    }
    public void Notify()
    {
        Debug.Log("Cylinder.cs/Notify called");
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
