using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConflictDetect : MonoBehaviour
{
    public AttackComponent attackComponent;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("NPC_Boy"))
        {
            attackComponent.SetTarget(collision.transform);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("NPC_Boy"))
        {
            attackComponent.SetTarget(collision.transform);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("NPC_Boy"))
        {
            attackComponent.SetTarget(null);
        }
    }
}
