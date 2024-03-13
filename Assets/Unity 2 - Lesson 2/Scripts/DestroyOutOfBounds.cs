using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Des : MonoBehaviour
{
    private float TopBound = 30;
    private float BotBound = -30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > TopBound)
        {
            Destroy(gameObject);

        }
        else if (transform.position.z < BotBound)
        {
            Destroy(gameObject);
        }
        
    }
}
