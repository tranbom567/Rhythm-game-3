using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public float duration;
    private GameObject player;
    private GameObject timeline;
    public GameObject followingObject;
    private bool isActive;
    private float calculateOffsetX, calculateOffsetY;
    public enum FollowType:byte
    {
        followX,
        followXY,
        deactFollow
    }
    public FollowType follow=FollowType.followX;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isActive = true;
            calculateOffsetX = followingObject.transform.position.x - transform.position.x;
            calculateOffsetY = followingObject.transform.position.y - transform.position.y;
            /*if (follow == FollowType.followX)
            {
                followingObject.transform.parent = timeline.transform;
            }
            else if (follow == FollowType.followXY)
                followingObject.transform.parent = player.transform;
            else
                followingObject.transform.parent = null;*/
        }   
    }
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        timeline = GameObject.FindWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            if (follow == FollowType.followX)
            {
                followingObject.transform.position = new Vector3(player.transform.position.x + calculateOffsetX, followingObject.transform.position.y);
            }
            else if (follow == FollowType.followXY)
            {
                followingObject.transform.position = new Vector3(player.transform.position.x + calculateOffsetX, player.transform.position.y + calculateOffsetY);
            }
            else
                GameObject.Destroy(gameObject);
        }   
    }
}
