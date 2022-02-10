using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaunCarRight : MonoBehaviour
{
    public GameObject[] CarR;
    public List<GameObject> activeTilesCarRight = new List<GameObject>();
    public float SpeedCarRight = -0.02f;
    public Transform SpawnPosRight;
    public int quantCarR = 7;
    public MovePlayer move;

    void Start()
    {
        StartCoroutine(SpawnCarsRight());
    }
    void Update()
    {
        for (int j = 0; j < activeTilesCarRight.Count; j++)
        {
            Vector3 moveR = new Vector3(SpeedCarRight, 0f, 0f);
            activeTilesCarRight[j].transform.position += moveR;
        }
    }
    private void SpawnCarRight(int tileIndexCarRight)
    {
        GameObject nextTileCarRight = Instantiate(CarR[tileIndexCarRight], SpawnPosRight.position, Quaternion.Euler(0, 90f, 0));
        activeTilesCarRight.Add(nextTileCarRight);
    }
    public IEnumerator SpawnCarsRight()
    {
        for (int i = 0; i < quantCarR;)
        {
            SpawnCarRight(Random.Range(0, CarR.Length));
            yield return new WaitForSeconds(Random.Range(4, quantCarR));
        }
    }


}
