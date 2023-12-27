using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody2D mybody;
    public float inputHorizon;
    public SpriteRenderer sprite;
    public Animator animator;

    public flags flag;


    public float walkspeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (flag.Talking_flag == false)
        {
            inputHorizon = Input.GetAxisRaw("Horizontal");

            if (inputHorizon != 0)
            {
                mybody.velocity = new Vector2(inputHorizon * walkspeed, 0f);
                animator.SetFloat("move", 1);
                if (inputHorizon == 1)
                {
                    sprite.flipX = false;
                }
                else
                {
                    sprite.flipX = true;
                }

            }
            else
            {
                animator.SetFloat("move", 0);
            }
        }
        else {

            animator.SetFloat("move", 0);
        }
    }
}
