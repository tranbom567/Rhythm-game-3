using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Ray : MonoBehaviour
{
    
    public float warnDistance=10;
    
    private float time = 0;
    [Range(0.1f, 100)]
    public float duration = 0.5f;
    private bool isTrigger;
   // private static Transform player { get; set; }
    private BoxCollider hitBoxes;
    private SpriteRenderer render;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
        if (other.gameObject.tag == "Player")
        {
            DOTween.Sequence().Join(render.DOColor(Color.white, 0f)).Join(render.DOColor(Color.red, 0.2f));
            isTrigger = true;
            
            
        }
    }

    private void Start()
    {
        
        render = transform.GetChild(0).GetComponent<SpriteRenderer>();
        hitBoxes = transform.GetChild(0).GetComponent<BoxCollider>();
    }
    private void Update()
    {
        if(Vector3.Distance(transform.position,PlayerManager.getInstance.getPlayer().transform.position)<warnDistance&&!isTrigger)
            render.color = new Color(render.color.r, render.color.g, render.color.b, Mathf.Lerp(render.color.a, 0.4f, 5 * Time.deltaTime));
        if (isTrigger)
            callThisWhenEnter();
    }
    public void callThisWhenEnter()
    {
        time += Time.deltaTime;
        //Debug.Log(this.transform.parent.gameObject);

        if (time <= duration)
        {
            render.color = new Color(render.color.r, render.color.g, render.color.b, 1);
            hitBoxes.enabled = true;
        }
        else if (time > duration)
        {
            render.color = new Color(render.color.r, render.color.g, render.color.b, Mathf.Lerp(render.color.a, 0f, 5 * Time.deltaTime));
            if (render.color.a <= 0.3f)
                hitBoxes.enabled = false;
        }

    }
}
