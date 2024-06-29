using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BoundParam:byte
{
    Up,
    Down
}
public class Bound : MonoBehaviour
{
    public BoundParam boundParameter;
    public Transform timeline;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (boundParameter == BoundParam.Up)

            transform.localPosition = (transform.up * (Camera.main.orthographicSize / 2))+transform.right*timeline.position.x;
        else if (boundParameter == BoundParam.Down)
            transform.localPosition = -transform.up * (Camera.main.orthographicSize / 2) + transform.right * timeline.position.x;
    }
}
