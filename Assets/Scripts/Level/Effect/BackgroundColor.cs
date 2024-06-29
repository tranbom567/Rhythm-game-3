using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundColor : MonoBehaviour
{
    public Color inColor;
    //private static Color targetcolor;
    public float duration=5;
    private bool isTriggered;
    public Ease easeType;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Debug.Log(PlayerManager.getInstance.bgScript.bg1.GetComponent<Image>());
            PlayerManager.getInstance.bgScript.bg1.GetComponent<RawImage>().DOColor(inColor, duration).SetEase(easeType);
            PlayerManager.getInstance.bgScript.bg2.GetComponent<RawImage>().DOColor(inColor, duration).SetEase(easeType);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (isTriggered)
        {
            PlayerManager.getInstance.bgScript.bg1.GetComponent<RawImage>().color = Color.Lerp(PlayerManager.getInstance.bgScript.bg1.GetComponent<RawImage>().color, targetcolor, Time.deltaTime / duration);
            PlayerManager.getInstance.bgScript.bg2.GetComponent<RawImage>().color = Color.Lerp(PlayerManager.getInstance.bgScript.bg2.GetComponent<RawImage>().color, targetcolor, Time.deltaTime / duration);
            if(PlayerManager.getInstance.bgScript.bg1.GetComponent<RawImage>().color==targetcolor&& PlayerManager.getInstance.bgScript.bg2.GetComponent<RawImage>().color == targetcolor)
            {
                GameObject.Destroy(gameObject);
            }
        }*/
    }
}
