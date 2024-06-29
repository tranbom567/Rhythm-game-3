using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    private float refSpeed;
    private bool canDash=true;
    private bool isDash;
    public bool ignoreDamage = false;
    public GameObject dashCircle;
    private Collider collide;
    private GameObject currentDash;
    void Start()
    {
        collide=GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"speed: {NormalMove.speed}");
        if (Input.GetKeyDown(KeyCode.Space) && canDash)
        {
            currentDash=GameObject.Instantiate(dashCircle,transform);
            currentDash.transform.parent = null;
            NormalMove.speed = 14 * 3.5f;
            isDash = true;
            canDash = false;
            ignoreDamage = true;
            StartCoroutine(dashing());
        }
        if (isDash)
        {
            NormalMove.speed = Mathf.SmoothDamp(NormalMove.speed, 14, ref refSpeed, 0.2f);
        }
    }
    IEnumerator dashing()
    {
        
        yield return new WaitForSeconds(0.6f);
        isDash = false;
        ignoreDamage = false;
        yield return new WaitForSeconds(0.1f);
        GameObject.Destroy(currentDash);
        canDash = true;
    }
}
