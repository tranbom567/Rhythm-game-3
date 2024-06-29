using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Playables;

public class MoveDuringGameTime : MonoBehaviour
{
    public PlayableDirector pd;
    
    
    public Animator timeLineAnimator;
    public GameObject TimeLine;
    public float startPos = 0;
    
    
    void Start()
    {
        pd.initialTime = startPos;
        Time.timeScale = 0;
          // pd.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && pd.state != PlayState.Playing)
        {
            Time.timeScale = 1;
            timeLineAnimator.enabled = true;
            pd.Play();
        }
        
        
        this.transform.position = new Vector3(TimeLine.transform.position.x, transform.position.y,transform.position.z);
        
    }
    
}
