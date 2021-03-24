using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleLineScript : MonoBehaviour
{
    public static bool passMiddleLine = false;
    void OnTriggerEnter() {
        passMiddleLine = true;
    }
}
