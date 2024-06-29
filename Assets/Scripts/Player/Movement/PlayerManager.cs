using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager getInstance;
    private int playerHealth = 15;
    public PostProcessVolume volume;
    public GameObject player;
    public BackgroundScript bgScript;
    public GameObject getPlayer() => player;
    public float speed = 0;
    private Vector3 lastPos = Vector3.zero;
    public int healthData
    {
        get => playerHealth;
    }
    
    void Start()
    {
        
        getInstance = this;
        bgScript = GetComponent<BackgroundScript>();
    }
    private void Update()
    {
        speed = (player.transform.position.x - lastPos.x) / Time.deltaTime;
        lastPos= player.transform.position;
    }
    public void decreasePlayerHealth(int decAmmount)
    {
        playerHealth -= decAmmount;
    }
}
