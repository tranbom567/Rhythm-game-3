using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualDeact : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
            GameObject.Destroy(GameObject.Find("Player2(Clone)"));
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
