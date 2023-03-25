using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class NPCSpawner : MonoBehaviour
{
    public Transform[] npc_Prefabs;
    private Transform next_npc;

    public Color[] npcSkinColours;
    int index;
    private int npcCount;
    public int maxNPCsForWave = 1;

    public float timeBetweenSpawn = 1f;
    public float timeBetweenWaves;

    public Transform[] spawnPoints;

    bool spawningWave;


    void Start()
    {
        SpawnNPCWave(maxNPCsForWave);
    }

    public void SpawnNPCWave(int npcAmount)
    {
        index = Random.Range(0, npc_Prefabs.Length);

        for (int i = 0; i < npcAmount; i++)//for each npc to spawn, spawn
        {
            npcCount++;
            //spawn npc at random spawn point

            index = Random.Range(0, npc_Prefabs.Length);
            next_npc = npc_Prefabs[index];

            Instantiate(next_npc, spawnPoints[Random.Range(0, spawnPoints.Length)].position, npc_Prefabs[index].transform.rotation);
        }
    }
}
