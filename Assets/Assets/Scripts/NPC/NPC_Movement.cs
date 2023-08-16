using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Movement : MonoBehaviour
{
    public SO_NPC_Boys SOBoys;
    private Rigidbody2D boy;
    public GameObject pointA;
    public GameObject pointB;
    public Animator animatorNPCMovement;
    private Transform currentPoint;
    //public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        boy = GetComponent<Rigidbody2D>();
        animatorNPCMovement = GetComponent<Animator>();
        currentPoint = pointB.transform;
        animatorNPCMovement.SetBool("isMoving", true);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentPoint.position - transform.position;
        if (currentPoint == pointB.transform)
        {
            boy.velocity = new Vector2(SOBoys.speed, 0);
        }
        else
        {
            boy.velocity = new Vector2(-SOBoys.speed, 0);
        }

        //float distance = Vector2.Distance(transform.position, currentPoint.position);
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointB.transform)
        {
            flip();
            currentPoint = pointA.transform;
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointA.transform)
        {
            flip();
            currentPoint = pointB.transform;
        }
            
    }

    private void flip()
    {
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
