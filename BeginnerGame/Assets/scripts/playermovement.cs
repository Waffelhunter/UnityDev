using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public CharacterController2D controller2D;
    float HorizontalMove = 0f;
    public float MovementSpeed = 0f;
    bool jump = false;
    private Rigidbody2D m_Rigidbody2D;
    public Animator animator;
    bool dash= false;
    bool shoot = false;
    


    // Update is called once per frame
    private void Awake()
    {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        HorizontalMove = Input.GetAxisRaw("Horizontal") * MovementSpeed;
        animator.SetFloat("Speed", Mathf.Abs(HorizontalMove));
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;


            animator.SetBool("IsJumping", true);
           



            //    animator.SetBool("IsJumping", false);
            //     animator.SetBool("IsFalling", true);


        }
        if (Input.GetKeyDown(KeyCode.LeftShift)){
            dash = true;
        }
        if (Input.GetMouseButtonDown(0))
        {
            shoot = true;
            
        }
    }
    public void OnLand()
    {
        animator.SetBool("IsJumping", false);
        
    }

    private void FixedUpdate()
    {
        controller2D.Move(HorizontalMove * Time.deltaTime, false, jump,dash,shoot) ;
        jump = false;
        dash = false;
        shoot = false;
    }
}
