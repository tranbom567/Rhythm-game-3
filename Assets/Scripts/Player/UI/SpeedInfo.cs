using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedInfo : MonoBehaviour
{
    private Text displayText;
    void Start()
    {
        displayText=GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        displayText.text = $"Horizontal Speed: {Mathf.RoundToInt(PlayerManager.getInstance.speed)}";
    }
}
