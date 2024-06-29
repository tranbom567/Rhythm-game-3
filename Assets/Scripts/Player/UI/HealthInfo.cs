using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthInfo : MonoBehaviour
{
    private Text heartText;
    void Start()
    {
        heartText=GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        heartText.text = $"Heart: {PlayerManager.getInstance.healthData}";
    }
}
