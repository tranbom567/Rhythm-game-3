using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class CameraShake : MonoBehaviour
{
    public float mag = 1;
    private float time = 0;
    public float duration;
    private bool isActive;
    public float initSpeed;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
            isActive = true;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(transform.position, transform.position + (Vector3.right * initSpeed * duration));
        if (isActive)
        {
            time += Time.deltaTime;
            if(time<=duration)
            {
                
                Camera.main.gameObject.transform.localPosition = new Vector3(Random.Range(-mag, mag), Random.Range(-mag, mag), 0);
            }
        }
        
    }
}
