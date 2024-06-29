using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class CameraOffset : MonoBehaviour
{
    private bool isActivated;
   // private static float targetOffset = 0;
    public float offsetX = 0;
    public float inDuration;
   // private static float duration;
    public float initSpeed;
    private float time = 0;
    public Ease easeType;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
          DOTween.Sequence().Join(DOTween.To(() => Cam.offsetX, target => Cam.offsetX = target, offsetX, inDuration).SetEase(easeType));
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(transform.position, transform.position + (Vector3.right * initSpeed * inDuration));
        /*if (isActivated)
        {
            Cam.offsetX=Mathf.Lerp(Cam.offsetX,targetOffset,Time.deltaTime/duration);
         
           
        }*/
    }
}
