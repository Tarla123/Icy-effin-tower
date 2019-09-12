using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D m_Rigidbody;

    Vector2 m_Jump = new Vector2();

    Vector2 velocity = new Vector2();

    public float m_JumpSpeed = 200f;

    private bool m_CanJump;

    
    // Start is called before the first frame update
    void Start()
    {
        m_Jump.y = m_JumpSpeed;

        m_CanJump = false;
        
        

    }

    // Update is called once per frame
    void Update()
    {
        

        velocity = m_Rigidbody.velocity;

        if(Input.GetKey(KeyCode.D))
        {
            velocity.x = 2f;
        }
        else if(Input.GetKey(KeyCode.A))
        {
            velocity.x = -2f;
        }
        else
        {
            velocity.x = 0f;
        }

        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (m_CanJump)
            {
                m_Rigidbody.AddForce(m_Jump);
                m_CanJump = false;
            }
        }

    }
    private void FixedUpdate()
    {
       
        

    

        m_Rigidbody.velocity = velocity;
    }

    private void OnCollisionEnter2D (Collision2D collision)

    {
        m_CanJump = true;
    }
}

