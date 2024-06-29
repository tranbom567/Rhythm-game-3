using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMode : MonoBehaviour
{
    public enum mode:byte
    {
        Per,
        Or
    }
    public mode CamMode=mode.Or;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (CamMode == mode.Per)
                Camera.main.orthographic = false;
            else
                Camera.main.orthographic = true;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
