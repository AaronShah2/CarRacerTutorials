using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleLineScript : MonoBehaviour
{
    void OnTriggerEnter() {
        Debug.Log("passsMiddleLine: " + passMiddleLine);
        passMiddleLine = true;
    }
}
