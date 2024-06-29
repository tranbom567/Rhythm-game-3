using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class CamSizeChange : MonoBehaviour
{
    private bool isColActive;
    public float inDuration;
    //private static float duration;
   // private static float sizeTarget = 0;
    public float sizeChangeTo;
    public float initSpeed;
    private float time;
    public Ease easeType;
    public static float normalSize { get; } = 7.56f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            DOTween.Sequence().Join(Camera.main.DOOrthoSize(sizeChangeTo,inDuration).SetEase(easeType));
        }
    }
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(transform.position, transform.position + (Vector3.right * initSpeed * inDuration));
        /*if (isColActive)
        {
            Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, sizeTarget,  Time.deltaTime/duration);
           
        }*/
    }
}
