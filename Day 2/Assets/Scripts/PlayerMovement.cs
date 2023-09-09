using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 1;
    private float hor;
    
    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(hor * speed * Time.deltaTime,0f));
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ICollectable collectable = collision.GetComponent<ICollectable>();
        if (collectable != null) 
        {
            collectable.onCollect();
            Destroy(collision.gameObject);
        }
    }


}
