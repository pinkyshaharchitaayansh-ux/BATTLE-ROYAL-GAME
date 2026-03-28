using UnityEngine;

public class LootSpawner : MonoBehaviour
{
    public GameObject lootPrefab;
    public Transform[] spawnPoints;

    void Start()
    {
        SpawnLoot();
    }

    void SpawnLoot()
    {
        foreach (Transform point in spawnPoints)
        {
            Instantiate(lootPrefab, point.position, Quaternion.identity);
        }
    }
}