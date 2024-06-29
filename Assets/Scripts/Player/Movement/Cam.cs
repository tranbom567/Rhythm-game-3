using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public Transform player;
    public static float offsetX { get; set; } =5;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"offset: {offsetX}");
        this.transform.position = new Vector3(player.position.x+offsetX, transform.position.y, transform.position.z);
    }
}
