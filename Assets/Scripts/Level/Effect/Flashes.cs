using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[ExecuteInEditMode]
public class Flashes : MonoBehaviour
{
    private Image flash;
    public float inDuration;
   // private static float duration;
    public float initSpeed;
    public Color inColor;
    private bool isTriggered;
   // private static Color targetColor;
    private float time = 0;
    public Ease easeType;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            DOTween.Sequence().Join(DOTween.Sequence().Join(flash.DOColor(inColor, inDuration).SetEase(easeType)));
            
        }
    }
    void Start()
    {
        flash=GameObject.Find("Flashing").GetComponent<Image>();
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.DrawLine(transform.position, transform.position + (Vector3.right * initSpeed * inDuration));
        /*if (isTriggered)
        {
            flash.color = Color.Lerp(flash.color, targetColor, Time.deltaTime / duration);
            if (flash.color==targetColor)
                GameObject.Destroy(gameObject);
        }*/
    }
}
