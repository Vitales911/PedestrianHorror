using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadPlayer : MonoBehaviour
{
    public bool Dead = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            Debug.Log("Car");
            Dead = true;
            Time.timeScale = 0;
        }
    }
}
