using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
[ExecuteInEditMode]
public class VigneteChange : MonoBehaviour
{
    //private static float targetVignete;
    private bool isTriggered;
    public float inDuration;
   // private static float duration;
    public float inVignete;
    public float initSpeed;
    private Vignette vig;
    private float time = 0;
    public Ease easeType;
    //def=0.2
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            DOTween.Sequence().Join(DOTween.To(() => vig.intensity.value, itensity => vig.intensity.value = itensity, inVignete, inDuration).SetEase(easeType));
        }
    }
    void Start()
    {
        GameObject.FindWithTag("MainCamera").GetComponent<PostProcessVolume>().profile.TryGetSettings<Vignette>(out vig);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"Player speed: {PlayerRuntime.currentSpeed}");
        Debug.DrawLine(transform.position, transform.position+(Vector3.right * initSpeed * inDuration));
        
        /*if (isTriggered)
        {
            
            vig.intensity.value = Mathf.Lerp(vig.intensity.value, targetVignete,   Time.deltaTime/duration);
           
        }*/
    }
}
