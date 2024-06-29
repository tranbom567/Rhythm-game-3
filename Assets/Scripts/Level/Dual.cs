using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dual : MonoBehaviour
{
    public GameObject player2;
    private GameObject initPlayer;
    private GameObject timeline;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
           initPlayer= GameObject.Instantiate(player2, transform.GetChild(0).GetChild(0).transform);
           initPlayer.transform.parent = timeline.transform;
           
        }
    }
    void Start()
    {
        timeline = GameObject.Find("Timeline");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
