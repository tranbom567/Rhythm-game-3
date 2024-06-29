using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEffect : MonoBehaviour
{
    public float duration;
    public GameObject rotateObject;
    public float rotateZ;
    [Min(0)]
    public int Loop360 = 0;
    public Ease easeType;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Loop360 == 0)
            {
                rotateObject.transform.DORotate(Vector3.forward * rotateZ, duration, RotateMode.Fast).SetEase(easeType);
            }else if (Loop360 != 0)
            {
                rotateObject.transform.DORotate(Vector3.forward * 360, duration, RotateMode.Fast)
                    .SetLoops(Loop360)
                    .SetRelative()
                    .SetEase(easeType);
            }
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
