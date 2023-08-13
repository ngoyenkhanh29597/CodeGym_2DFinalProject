using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting_2 : MonoBehaviour
{
    private Camera cam;
    [SerializeField, Range(1, 100)] private float roationSpeed = 1;
    [SerializeField] private Beam beamPrefab;
    [SerializeField] private Transform spawnPoint;

    void Awake()
    {
        cam = Camera.main;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;
        var dir = mousePosition - transform.position;
        transform.up = Vector3.MoveTowards(transform.up, dir, roationSpeed * Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(beamPrefab, spawnPoint.position, Quaternion.identity).Init(transform.up);
        }
    }
}
