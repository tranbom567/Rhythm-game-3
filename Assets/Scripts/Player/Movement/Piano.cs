using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piano : MonoBehaviour
{
    private float y = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
            y = 5;
        else if (Input.GetKeyDown(KeyCode.F))
            y = 0;
        else if (Input.GetKeyDown(KeyCode.G))
            y = -5;
        transform.position=new Vector3(transform.position.x,y,transform.position.z);
    }
}
