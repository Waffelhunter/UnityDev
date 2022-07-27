using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public CharacterController2D controller2D;
    float HorizontalMove = 0f;
    public float MovementSpeed = 0f;
    bool jump = false;

    // Update is called once per frame
    void Update()
    {
        HorizontalMove = Input.GetAxisRaw("Horizontal")*MovementSpeed;
        if (Input.GetButtonDown("Jump"))
            {
            jump = true;
            }
    }

    private void FixedUpdate()
    {
        controller2D.Move(HorizontalMove * Time.deltaTime, false, jump) ;
        jump = false;
    }
}
