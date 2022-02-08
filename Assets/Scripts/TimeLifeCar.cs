using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeLifeCar : MonoBehaviour
{
    [SerializeField] public float timeLife = 5f;
    private void Update()
    {
        timeLife -= Time.deltaTime;
        //if (timeLife <= 0)
        //{

        //    spaunCar.activeTilesCarLeft.Remove(gameObject);
        //    //Destroy(gameObject);
        //    for (int i = 0; i < spaunCar.activeTilesCarLeft.Count; i++) { }

        //}
        //if (timeLife <= 0)
        //{            
        //    spaunCar.activeTilesCarRight.Remove(gameObject);
        //    //Destroy(gameObject);
        //    for (int i = 0; i < spaunCar.activeTilesCarRight.Count; i++) { }

        //}
    }
}