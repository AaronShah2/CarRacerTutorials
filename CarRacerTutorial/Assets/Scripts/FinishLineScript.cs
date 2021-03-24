﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinishLineScript : MonoBehaviour
{
    public TextMeshProUGUI lapText;
    private int lapCounter = 0;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider col)
    {
        if(col.name =="ColliderBody"& MiddleLineScript.passMiddleLine)
        {
            MiddleLineScript.passMiddleLine = false;
            lapCounter++;
            lapText.text = "Lap: " + lapCounter.ToString();
        }
    }
}
