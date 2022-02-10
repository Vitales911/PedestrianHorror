using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWin : MonoBehaviour
{
    public bool Won = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("WonPlayer"))
        {
            Debug.Log("WonPlayer!");
            Won = true;
            Time.timeScale = 0;
        }
    }
}
