using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaunCarLeft : MonoBehaviour
{
    public GameObject[] CarL;
    public List<GameObject> activeTilesCarLeft = new List<GameObject>();
    public float SpeedCarLeft = 0.02f;
    public Transform SpawnPosLeft;
    public int quantCarL = 7;
    void Start()
    {
        StartCoroutine(SpawnCarsLeft());
    }
    void Update()
    {
        for (int i = 0; i < activeTilesCarLeft.Count; i++)
        {
            Vector3 moveL = new Vector3(SpeedCarLeft, 0f, 0f);
            activeTilesCarLeft[i].transform.position += moveL;
        }
    }
    private void SpawnCarLeft(int tileIndexCarLeft)
    {
        GameObject nextTileCarLeft = Instantiate(CarL[tileIndexCarLeft], SpawnPosLeft.position, Quaternion.Euler(0, -90f, 0));
        activeTilesCarLeft.Add(nextTileCarLeft);
    }
    public IEnumerator SpawnCarsLeft()
    {
        for (int i = 0; i < quantCarL;)
        {
            SpawnCarLeft(Random.Range(0, CarL.Length));
            yield return new WaitForSeconds(Random.Range(4, quantCarL));
        }
    }
}
