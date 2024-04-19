using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullate : MonoBehaviour


{
    public float Speed;
    private Rigidbody2D Rigidbody2D;
    private Vector2 Direction;
    

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Rigidbody2D.velocity = transform.right * Speed; // Mover en la dirección local hacia adelante (derecha)
    }

    public void SetDirection (Vector2 direction)
    {
        // Girar el bullet en la dirección correcta
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
    
}
