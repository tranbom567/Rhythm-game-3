using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRuntime : MonoBehaviour
{

    private AudioSource playerHit;
    private Dash playerDash;
    public static float currentSpeed;
    private Vector3 lastPos = Vector3.zero;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Enemy")&&!playerDash.ignoreDamage)
        {
            playerHit.Play();
            Debug.Log("Decrease health");
            PlayerManager.getInstance.decreasePlayerHealth(1);
        }
    }
    
    void Start()
    {
        playerDash=GetComponent<Dash>();
        playerHit=GameObject.FindWithTag("Player").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        currentSpeed = (transform.position.x-lastPos.x) / Time.deltaTime;
        lastPos = transform.position;
    }
}
