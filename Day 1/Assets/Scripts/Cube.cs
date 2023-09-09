using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour, IObserver
{
    private void OnEnable()
    {
        GameManager.onSpacePressed += Notify;
    }
    public void Notify()
    {
        Debug.Log("Cube.cs/Notify called");
        GetComponent<MeshRenderer>().material.color = Color.black;
    }
    
}
