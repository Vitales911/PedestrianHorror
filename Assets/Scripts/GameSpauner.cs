using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpauner : MonoBehaviour
{
    public GameObject[] TilePrefabsRoad;
    public GameObject[] TilePrefabsPlane;
    private List<GameObject> activeTiles = new List<GameObject>();
    private List<GameObject> activeTilesPlane = new List<GameObject>();
    private float spawnPosRoad = 7.5f;
    private float spawnPosPlane = 11.5f;
    private float tileLengthRoad = 8f;
    private float tileLengthPlane = 8f;


    [SerializeField] private Transform player;
    private int startTilesRoad = 3;
    private int startTilesPlane = 3;

    void Start()
    {
        for (int i = 0; i < startTilesRoad; i++)
        {
             SpawnTileRoad(Random.Range(0, TilePrefabsRoad.Length));
        }
        for (int j = 0; j < startTilesPlane; j++)
        {
            SpawnTilePlane(Random.Range(0, TilePrefabsPlane.Length));
        }
    }

    void Update()
    {
        if (player.position.z - 60 > spawnPosRoad - (startTilesRoad * tileLengthRoad))
        {
            if (player.position.z - 60 > spawnPosPlane - (startTilesPlane * tileLengthPlane))
            {
                SpawnTileRoad(Random.Range(0, TilePrefabsRoad.Length));
                SpawnTilePlane(Random.Range(0, TilePrefabsPlane.Length));
                DeleteTile();
            }

        }
    }

    private void SpawnTileRoad(int tileIndex)
    {
        GameObject nextTile = Instantiate(TilePrefabsRoad[tileIndex], transform.forward * spawnPosRoad, transform.rotation);
        activeTiles.Add(nextTile);
        spawnPosRoad += tileLengthRoad;

    }
    private void SpawnTilePlane (int tileIndexPlane)
    {
        GameObject nextTilePlane = Instantiate(TilePrefabsPlane[tileIndexPlane], transform.forward * spawnPosPlane, transform.rotation);
        activeTilesPlane.Add(nextTilePlane);
        spawnPosPlane += tileLengthPlane;
    }
    private void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
        Destroy(activeTilesPlane[0]);
        activeTilesPlane.RemoveAt(0);
    }
}
