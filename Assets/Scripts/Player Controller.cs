using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//360 degree movement
public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public Vector2 moveDirection;
    public Rigidbody2D rb;
    void Update()
    {
        moveDirection.x = Input.GetAxisRaw("Horizontal");
        moveDirection.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
       rb.MovePosition(rb.position + moveDirection * speed * Time.fixedDeltaTime);
    }


}
