using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidePlayer : MonoBehaviour
{
    public bool isHide = true;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (isHide)
            {
                other.gameObject.GetComponent<SpriteRenderer>().color *= new Color(1, 1, 1, 0);
            }
            else
            {
                other.gameObject.GetComponent<SpriteRenderer>().color = new Color(other.gameObject.GetComponent<SpriteRenderer>().color.r
                    , other.gameObject.GetComponent<SpriteRenderer>().color.g
                    , other.gameObject.GetComponent<SpriteRenderer>().color.b
                    , 1);
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
