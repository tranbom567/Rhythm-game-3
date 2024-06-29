using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NormalMove : MonoBehaviour
{
    public float y { get; set; } = 0;

    public static float speed { get; set; } = 14;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        y =transform.position.y+( speed * Time.deltaTime * Input.GetAxis("Vertical"));
        //Vector3 boundPoint = Camera.main.ScreenToWorldPoint(new Vector3(0, Camera.main.pixelHeight, Camera.main.nearClipPlane));
       // Debug.Log($"bound: {Camera.main.orthographicSize}");
        y = Mathf.Clamp(y, -Camera.main.orthographicSize, Camera.main.orthographicSize);
        this.transform.position = new Vector3(transform.position.x, y, transform.position.z);
    }
   
}
