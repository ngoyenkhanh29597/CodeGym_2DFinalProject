using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boys : MonoBehaviour
{
    [SerializeField] private GameObject explode;

    public void GetShot()
    {
        Instantiate(explode, transform.position, Quaternion.Euler(90, 0, 0));
        Destroy(gameObject);
    }
}
