using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    private bool triggered;
    private bool end;
    private SpriteRenderer render;
    public int initAngle = 0;
    public int endAngle = 360;
    public GameObject ammo;
    public int ammount=6;
    public float duration=0;
    public float ammoSpeed=25;
    public float warnDistance = 10;
    private GameObject insObject;
    private ArrayList al = new ArrayList();
    private BoxCollider hitBoxes;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            DOTween.Sequence().Join(render.DOColor(Color.white, 0f)).Join(render.DOColor(Color.red, 0.2f));
            StartCoroutine(spawnAmmo());
            triggered = true;
        }
    }
    IEnumerator spawnAmmo()
    {
        for (int i = initAngle; i < endAngle; i += (endAngle-initAngle) / ammount)
        {
            insObject = GameObject.Instantiate(ammo, this.transform.GetChild(0));
            
            insObject.GetComponent<Ammo>().direction = new Vector3(Mathf.Cos(i * (Mathf.PI / 180)), Mathf.Sin(i * (Mathf.PI / 180)), 0);
            insObject.GetComponent<Ammo>().speed = ammoSpeed;
            al.Add(insObject);
            yield return new WaitForSeconds(duration);
        }
        
        end = true;
        
    }
    // Start is called before the first frame update
    void Start()
    {
        render= transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>();
        hitBoxes = transform.GetChild(0).GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, PlayerManager.getInstance.getPlayer().transform.position) < warnDistance && !triggered)
        {
            render.color = new Color(render.color.r, render.color.g, render.color.b, Mathf.Lerp(render.color.a, 0.3f, 5 * Time.deltaTime));
            hitBoxes.enabled = true;
        }
        if (end)
        {
            render.color = new Color(render.color.r, render.color.g, render.color.b, Mathf.Lerp(render.color.a, 0f, 5 * Time.deltaTime));
            if (render.color.a <= 0.5f)
                hitBoxes.enabled = false;
        }
    }
}
