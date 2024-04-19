using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frog : MonoBehaviour
{
    public GameObject bullets;
    public float runSpeed = 2;
    public float jumpSpeed = 3;
    Rigidbody2D rb2D;

    public SpriteRenderer spriteRenderer;
    public Animator animator;

    

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2D.velocity = new Vector2(runSpeed, rb2D.velocity.y);
            spriteRenderer.flipX = false;
            animator.SetBool("Run", true);

        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2D.velocity = new Vector2(-runSpeed, rb2D.velocity.y);
            spriteRenderer.flipX = true;
            animator.SetBool("Run", true);
        }
        else
        {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
            animator.SetBool("Run", false);

        }

        //Salto
        if (Input.GetKey("space") && checkground.isGround)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
            animator.SetBool("Run", false);
        }
        //Disparo
        if (Input.GetKeyDown(KeyCode.L))
        {
            Shoot();
        }

    }

    private void Shoot()
    {
        // Determinar la dirección del disparo (hacia la derecha o la izquierda)
        Vector2 direction = spriteRenderer.flipX ? Vector2.left : Vector2.right;

        // Instanciar el bullet y configurar su dirección
        GameObject bulletObject = Instantiate(bullets, transform.position, Quaternion.identity);
        bullate bulletScript = bulletObject.GetComponent<bullate>();
        if (bulletScript != null)
        {
            bulletScript.SetDirection(direction);
        }

    }



}


