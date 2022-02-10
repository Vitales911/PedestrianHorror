using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCarLeft : MonoBehaviour
{
    public SpaunCarRight spaunCarR;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            for (int j = 0; j < spaunCarR.activeTilesCarRight.Count;)
            {
                Destroy(spaunCarR.activeTilesCarRight[j]);
                spaunCarR.activeTilesCarRight.RemoveAt(j);
                break;
            }
        }
    }
}
