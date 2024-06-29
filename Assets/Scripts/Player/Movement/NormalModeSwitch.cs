using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalModeSwitch : MonoBehaviour
{
    
    public float initY=0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            other.gameObject.GetComponent<Piano>().enabled = false;
            other.gameObject.GetComponent<NormalMove>().y= initY;
            other.gameObject.GetComponent<Dash>().enabled = true;
            other.gameObject.GetComponent<NormalMove>().enabled = true;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
