using DG.Tweening;
using DG.Tweening.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class Rotate : MonoBehaviour
{
    public float duration=5;
    // Start is called before the first frame update
    void Start()
    {
        
        transform.DORotate(Vector3.forward * 360, duration, RotateMode.Fast)
            .SetLoops(-1)
            .SetRelative()
            .SetEase(Ease.Linear);
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
