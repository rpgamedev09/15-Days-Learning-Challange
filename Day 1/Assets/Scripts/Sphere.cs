using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour, IObserver
{
    private void OnEnable()
    {
        GameManager.onSpacePressed += Notify;
    }
    public void Notify()
    {

        Debug.Log("Sphere.cs/Notify called");
        GetComponent<MeshRenderer>().material.color = Color.yellow;
    }
}
