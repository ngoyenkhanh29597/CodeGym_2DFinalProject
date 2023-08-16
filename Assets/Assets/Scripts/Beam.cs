using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour
{
    public float loveDmg;

    public void setLoveDamage(float lovedmg)
    {
        this.loveDmg = lovedmg;
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
                boy.TakeLove(this.loveDmg);
                Debug.Log("Boy gets hit");
                Destroy(gameObject);
            }
        }
    }
}
