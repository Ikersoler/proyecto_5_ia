using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject[] TagPrefab;

    private float minX = -3.75f;

    private float minY = -3.75f;

    private float distandeBetuinCenters = 2.5f;

    private bool isGameOver;

    private float spawnRate = 0.5f;

    private Vector3 randomPos;

    public List<Vector3> targetPositionInScne;

    private void Awake()
    {
         targetPositionInScne = new List<Vector3>();
    }

    private void Start()
    {
        StartCoroutine(SpawnRandomTarget());
    }

    private Vector3 RamdomSpawnPosition()
    {
        float spawnPosX = minX + Random.Range(0, 4) * distandeBetuinCenters;
        float spawnPosY = minY + Random.Range(0, 4) * distandeBetuinCenters;

        return new Vector3(spawnPosX, spawnPosY, 0);
    }


    private IEnumerator SpawnRandomTarget()
    {
        while (!isGameOver) 
        {
            yield return new WaitForSeconds(spawnRate);

            randomPos = RamdomSpawnPosition();
            While(targetPositionInScne.Contains(randomPos))
                 {
                  randomPos = RamdomSpawnPosition();
                 }




            int randomPrefabIndex = Random.Range(0, TagPrefab.Length);
            Instantiate(TagPrefab[randomPrefabIndex], RamdomSpawnPosition(), TagPrefab[randomPrefabIndex].transform.rotation);

            targetPositionInScne.Add (randomPos);
            
        }
    }




}
