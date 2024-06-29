using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class Split : MonoBehaviour
{
    private Material splitMat;
    public float duration;
    public float initSpeed;
    public float ammount;
    private bool isTriggered;
    public Ease easeType;
   // private static float targetDuration;
    //private static float targetAmmount;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            DOTween.Sequence().Join(DOTween.To(() => CamSplitApply.ammount, ammount => CamSplitApply.ammount = ammount, ammount, duration).SetEase(easeType));
        }
            
    }
    void Start()
    {
        splitMat = GameObject.FindWithTag("MainCamera").GetComponent<CamSplitApply>().mat;
    }
    private void Update()
    {
        Debug.DrawLine(transform.position, transform.position + (Vector3.right * initSpeed * duration));
       /* if (isTriggered)
        {
            splitMat.SetFloat("_Ammount",
                Mathf.Lerp(splitMat.GetFloat("_Ammount"), targetAmmount, Time.deltaTime / targetDuration)
                );
        }*/
    }
    
}
