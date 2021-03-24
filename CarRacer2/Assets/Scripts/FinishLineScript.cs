using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinishLineScript : MonoBehaviour
{
    public TextMeshProUGUI lapText;
    private int lapCounter = 0;
  
    private void OnTriggerEnter(Collider col)
    {
        if(col.name == "ColliderBody" && Checkpoint.passMiddleLine)
        {
            Checkpoint.passMiddleLine = false; 
            lapCounter++;
            lapText.text = "Lap: " + lapCounter.ToString();
        }
    }
}
