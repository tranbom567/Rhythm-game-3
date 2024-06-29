using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoModeSwitch : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            player.GetComponent<NormalMove>().enabled = false;
            player.GetComponent<Dash>().enabled = false;
            player.GetComponent<Piano>().enabled = true;
            isActive = true;
        }
    }
    private GameObject player;
    private bool isActive;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            player.transform.position = new Vector3(player.transform.position.x, Mathf.Lerp(player.transform.position.y, 0, 6 * Time.deltaTime), player.transform.position.z);
            if (Mathf.Round(player.transform.position.y) == 0)
            {
                player.transform.position = new Vector3(player.transform.position.x, 0, player.transform.position.z);
                isActive = false;
            }
        }
    }
}
