using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class Move : MonoBehaviour
{
    public enum MoveType : byte
    {
        moveBy,
        moveToTarget
    }
    public float duration;
    public MoveType moveType= MoveType.moveBy;
    public GameObject target;
    public GameObject movingObject;
    public float moveByX;
    public float moveByY;
    public Ease easeType;
    public float initSpeed;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (moveType == MoveType.moveBy)
                DOTween.Sequence().Join(movingObject.transform.DOMove(new Vector3(movingObject.transform.position.x + moveByX, movingObject.transform.position.y + moveByY, movingObject.transform.position.z), duration).SetEase(easeType));
            else
                DOTween.Sequence().Join(movingObject.transform.DOMove(target.transform.position, duration).SetEase(easeType));

        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(transform.position, Vector3.right * (transform.position.x + (initSpeed * duration))+Vector3.up*transform.position.y);
    }
}
