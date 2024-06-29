using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class CamRotateEffect : MonoBehaviour
{
    private bool isActivated;
    //private static float rotateZ { get; set; }=0;
    public float rotateZIn;
    public float inDuration;
   // private static float duration;
    public float initSpeed;
    private float time = 0;
    public RotateMode rotMode;
    public Ease easeType;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            DOTween.Sequence().Join(Camera.main.gameObject.transform.DORotate(Vector3.forward * rotateZIn, inDuration, rotMode).SetEase(easeType));
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(transform.position, transform.position + (Vector3.right * initSpeed * inDuration));
       /* if (isActivated)
        {
            Camera.main.gameObject.transform.localRotation =Quaternion.Lerp(Camera.main.gameObject.transform.localRotation, Quaternion.Euler(Camera.main.gameObject.transform.localRotation.x,
                Camera.main.gameObject.transform.localRotation.y,
                rotateZ
                ),Time.deltaTime/duration);
          
        
        }*/
    }
}
