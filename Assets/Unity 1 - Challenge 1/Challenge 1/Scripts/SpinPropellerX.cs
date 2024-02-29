using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Rotate the propeller
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);

        // Rotate the propeller based on user input
        float verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.right * verticalInput * rotationSpeed * Time.deltaTime);
    }
}

