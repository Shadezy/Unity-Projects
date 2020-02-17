using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    private float movementSpeed = 15.0f;
    private float xRange = 10.0f;

    public GameObject projectivePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
            transform.position = new Vector3(-xRange, transform.position.y);
        else if (transform.position.x > xRange)
            transform.position = new Vector3(xRange, transform.position.y);
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * movementSpeed * horizontalInput * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectivePrefab, transform.position, projectivePrefab.transform.rotation);
        }
    }
}
