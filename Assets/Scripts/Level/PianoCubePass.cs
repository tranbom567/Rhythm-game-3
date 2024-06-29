using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoCubePass : MonoBehaviour
{
    private AudioSource playerHit;
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("Timeline"))
        {
            PlayerManager.getInstance.decreasePlayerHealth(1);
            playerHit.Play();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
            GameObject.Destroy(this.gameObject);
    }
    void Start()
    {
        playerHit = GameObject.FindWithTag("Player").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
