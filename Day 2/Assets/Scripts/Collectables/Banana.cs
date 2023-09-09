using UnityEngine;

public class Banana : MonoBehaviour,ICollectable
{
    private int consumeRate = 3;
    public void onCollect()
    {
        GameManager.instance.shield += consumeRate;
    }
}
