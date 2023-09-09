using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour, ICollectable
{
    private int consumeRate = 3;
    public void onCollect()
    {
        GameManager.instance.health += consumeRate;
    }
}
