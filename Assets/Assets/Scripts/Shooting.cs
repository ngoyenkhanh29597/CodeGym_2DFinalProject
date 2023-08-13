using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject targetAim;
    public GameObject player;
    private Vector3 target;
    public GameObject bullet;
    //public GameObject bulletStart;

    public float bulletSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z)); //Get mouse's postion
        targetAim.transform.position = new Vector2(target.x, target.y); //Attach target aim's position to mouse's position

        Vector3 difference = target - player.transform.position; //Find vector between two points (from player's position to the mouse's position)
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg; //Find the angle between x-axis and the difference vector 
        //player.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);

        if (Input.GetMouseButtonDown(0)) //Get mouse's click event
        {
            Vector2 direction = difference;
            direction.Normalize();
            fireBullet(direction, rotationZ);
        }
    }

    void fireBullet(Vector2 direction, float rotationZ)
    {
        GameObject b = Instantiate(bullet) as GameObject;
        b.transform.position = player.transform.position;
        b.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        b.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
    }
}
