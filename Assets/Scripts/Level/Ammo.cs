using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    public Vector3 direction { get; set; }= Vector3.zero;
    private SpriteRenderer render;
    public float speed { get; set; } = 10;
    void Start()
    {
        render=GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        Vector3 boundUp = Camera.main.ScreenToWorldPoint(new Vector3(0, Camera.main.pixelHeight, Camera.main.nearClipPlane));
        Vector3 boundHor=Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelWidth,Camera.main.pixelHeight,Camera.main.nearClipPlane));
        if (transform.position.x > (boundHor.x + render.size.x))
            GameObject.Destroy(this.gameObject);
        else if (transform.position.x < (boundUp.x - render.size.x))
            GameObject.Destroy(this.gameObject);
        else if (transform.position.y > (boundUp.y + render.size.x))
            GameObject.Destroy(this.gameObject);
        else if(transform.position.y<(-boundUp.y-render.size.y)) 
            GameObject.Destroy(this.gameObject);
        this.transform.position += direction * speed * Time.deltaTime;
    }
}
