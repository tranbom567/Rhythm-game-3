using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleEffect : MonoBehaviour
{
    public Transform scaleObject;
    public float scaleX;
    public float scaleY;
    public float scaleZ;
    public float duration;
    public Ease easeType;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            scaleObject.DOScale(new Vector3(scaleX, scaleY, scaleZ), duration).SetEase(easeType);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
