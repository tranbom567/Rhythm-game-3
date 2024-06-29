using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player2Move : MonoBehaviour
{
    
    private float y = 0;
    // Start is called before the first frame update
    void Start()
    {
        y = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        y += NormalMove.speed * Time.deltaTime * Input.GetAxis("Vertical");
        //Vector3 boundPoint = Camera.main.ScreenToWorldPoint(new Vector3(0, Camera.main.pixelHeight/2, Camera.main.nearClipPlane));
        y = Mathf.Clamp(y, -Camera.main.orthographicSize, Camera.main.orthographicSize);
        this.transform.position = new Vector3(transform.position.x, y, transform.position.z);
    }
   
}
