using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinMerahPrefab;
    public GameObject coinKuningPrefab;
    public GameObject coinHijauPrefab;
    public GameObject coinBiruPrefab;
    public GameObject coinHitamPrefab;

    public int jumlahCoinMerah = 15;
    public int jumlahCoinKuning = 3;
    public int jumlahCoinHijau = 2;
    public int jumlahCoinBiru = 10;
    public int jumlahCoinHitam = 20;

    void Start()
    {
        SpawnCoins(coinMerahPrefab, jumlahCoinMerah);
        SpawnCoins(coinKuningPrefab, jumlahCoinKuning);
        SpawnCoins(coinHijauPrefab, jumlahCoinHijau);
        SpawnCoins(coinBiruPrefab, jumlahCoinBiru);
        SpawnCoins(coinHitamPrefab, jumlahCoinHitam);
    }

    void SpawnCoins(GameObject prefab, int jumlah)
    {
        for (int i = 0; i < jumlah; i++)
        {
            Vector3 spawnPosition = GetRandomSpawnPosition();
            Instantiate(prefab, spawnPosition, Quaternion.identity);
        }
    }

    Vector3 GetRandomSpawnPosition()
    {
        float x = Random.Range(-10f, 10f); // Adjust the range as needed
        float z = Random.Range(-10f, 10f); // Adjust the range as needed
        float y = 1.29999995f; // Set the y-value to the specified value

        return new Vector3(x, y, z);
    }
}
