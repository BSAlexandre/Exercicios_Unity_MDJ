using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carro_Controller : MonoBehaviour
{
    // Start is called before the first frame update

    private float spd = 20f;
    private float turnspd = 45f;
    private float horizontalInput;
    private float forwardInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //caro anda para a frente
        transform.Translate(Vector3.forward * Time.deltaTime * spd);
        //carro roda a saia
        transform.Rotate(Vector3.up, turnspd * Time.deltaTime * horizontalInput);
    }
}
