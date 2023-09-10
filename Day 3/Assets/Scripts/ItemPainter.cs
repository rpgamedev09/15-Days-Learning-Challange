/*
 *Were Understanding the importance of sofware architecture which allow us to design scalable and easy to modify systems 
 * Just Like we Did in following example where we are using a log function in order to print on console rather than indevidual
 * 
 *
 *
 */


using UnityEngine;

public class ItemPainter : MonoBehaviour 
{
    [SerializeField] GameObject cubePrefab;
    [SerializeField] Camera cam;
    [SerializeField] LayerMask groundLayer;

    bool hitSurface = false;
    [SerializeField] bool showLogs = false;   
    private void Update()
    {
        //casting a ray and checking if it hit the ground or not 
        var ray = cam.ScreenPointToRay(Input.mousePosition);
        hitSurface = Physics.Raycast(ray,out var hit ,1000, groundLayer);

        var clicked = Input.GetMouseButtonDown(0);

        if (hitSurface)
        {
            //Debug.Log("<color=green>Surphase Found</color> ");
            Log("<color=green>Surphase Found</color> ");
            if (clicked)
            {
                //Debug.Log("On Surface Clicked ....");
                Log("On Surface Clicked ....");
                var item = Instantiate(cubePrefab, hit.point,
                    Quaternion.identity);
                //Debug.Log("Object Spawned");
                Log("Object Spawned");
            }
        }
        else
        {
            //Debug.Log("<color=red> Surphase Not Found !!! </color>");
            Log("<color=red> Surphase Not Found !!! </color>");
        }

    } 
   void Log(object message)
   {
        if (showLogs)
            Debug.Log(message);
    }
}
