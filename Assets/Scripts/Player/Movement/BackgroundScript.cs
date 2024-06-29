using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundScript : MonoBehaviour
{
    public bool isMoving;
    public GameObject bg1;
    public GameObject bg2;
    private RectTransform bg1R;
    private RectTransform bg2R;
    private RawImage originalImage;
    public float speed = 2;
    private bool bg1Replaced;
    private bool bg2Replaced;
    void Start()
    {
        bg1R = bg1.GetComponent<RectTransform>();
        bg2R=bg2.GetComponent<RectTransform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            bg1R.anchoredPosition -=Vector2.right* speed * Time.deltaTime;
            bg2R.anchoredPosition -= Vector2.right * speed * Time.deltaTime;
            if (bg1R.anchoredPosition.x <= 0&&!bg2Replaced)
            {
                bg2R.anchoredPosition = new Vector2(bg1R.rect.width-1, 0);
                //bg2R.rotation = Quaternion.Euler(Vector3.up * 180);
                bg2Replaced=true;
                bg1Replaced = false;
            }else if(bg2R.anchoredPosition.x<=0/2&&!bg1Replaced)
            {
                bg1R.anchoredPosition = new Vector2(bg2R.rect.width-1, 0);
                //bg1R.rotation = Quaternion.Euler(Vector3.up * 180);
                bg1Replaced = true;
                bg2Replaced = false;
            }
        }
        else
        {
            bg1R.anchoredPosition = Vector2.right * 0;
        }
    }
}
