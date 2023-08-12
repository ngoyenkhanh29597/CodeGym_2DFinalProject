using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAnimation : MonoBehaviour
{
    public float speedMove;
    public bool isMoving;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement * speedMove * Time.deltaTime, 0, 0);

        if (movement == 0)
        {
            isMoving = false;
        }
        else
        {
            isMoving = true;
        }
        if (movement > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (movement < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }


        animator.SetBool("Move", isMoving);
    }

}
