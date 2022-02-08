using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCarRight : MonoBehaviour
{
    public SpaunCarLeft spaunCarL;
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        for (int i = 0; i < spaunCarL.activeTilesCarLeft.Count;)
        {
            Destroy(spaunCarL.activeTilesCarLeft[i]);
            spaunCarL.activeTilesCarLeft.RemoveAt(i);
            break;
        }
    }
}
