using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class FinishLineScript : MonoBehaviour
{
    public TextMeshProUGUI lapText;
    private int lapCounter = 0;

    private void OnTriggerEnter(Collider other) {
        if(other.name == "ColliderBody" & MiddleLineScript.passMiddleLine) {
            MiddleLineScript.passMiddleLine = false;
            lapCounter = lapCounter + 1;
            lapText.text = "Lap: " + lapCounter;
        }
    }
}
