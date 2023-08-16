using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Beam : MonoBehaviour
{
    public float speed;
    public float timeDestroy;
    private float timeDestroyCurrent = 0;

    public float NPC_loveDmg;

    public void setLoveDamage(float lovedmg)
    {
        this.NPC_loveDmg = lovedmg;
    }


    private void Update()
    {
        timeDestroyCurrent += Time.deltaTime;
        if (timeDestroyCurrent >= timeDestroy)
        {
            //timeDestroyCurrent = 0;
            Destroy(gameObject);
            return;
        }

        transform.position += transform.right * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.gameObject.tag == "NPC_Boy")
        //{
        //    
        //    Destroy(gameObject);
        //}

        if (collision.CompareTag("NPC_Boy"))
        {
            NPC_Boys boy = collision.GetComponent<NPC_Boys>();
            if (boy != null)
            {
                boy.TakeLove(this.NPC_loveDmg);
                Debug.Log("Other girls are attacking !!!");
                Destroy(gameObject);
            }
        }

    }
}
