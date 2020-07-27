using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{ 
    [SerializeField]
    //used for single enemy spawn
    private float xLimit;

    [SerializeField]
    //redefine positions
    private float[] xPositions;
    //
    [SerializeField]
    private GameObject[] prefabs;
    //
    [SerializeField]
    private Wave[] wave;

    private float currentTime;

    List<float> remainingPositions = new List<float>();
    private int waveIndex;
    float xPos = 0;
    int rand;

    void Start()
    {
        currentTime = 0;
        remainingPositions.AddRange(xPositions);
    }

    void Update()
    {
        currentTime -= Time.deltaTime;
        if (currentTime <= 0)
        {
            SelectWave();
        }
    }

    void SpawnEnemy(float xPos)
    {
        // 0,# types of objects
        int r = Random.Range(0, 1);
        GameObject enemyObj = Instantiate(prefabs[r], new Vector3(xPos, transform.position.y, 0), Quaternion.identity);

    }

    //Spawn Wave
    void SelectWave()
    {
        remainingPositions = new List<float>();
        remainingPositions.AddRange(xPositions);

        waveIndex = Random.Range(0, wave.Length);

        currentTime = wave[waveIndex].delayTime;

        if (wave[waveIndex].spawnAmount == 1)
            xPos = Random.Range(-xLimit, xLimit);
        else if (wave[waveIndex].spawnAmount > 1)
        {
            rand = Random.Range(0, remainingPositions.Count);
            xPos = remainingPositions[rand];
            //so it doesn't do the same wave beforehand
            remainingPositions.RemoveAt(rand);
        }

        for (int i = 0; i < wave[waveIndex].spawnAmount; i++)
        {
            SpawnEnemy(xPos);
            rand = Random.Range(0, remainingPositions.Count);
            xPos = remainingPositions[rand];
            remainingPositions.RemoveAt(rand);
        }
    }
}


[System.Serializable]
public class Wave
{
    public float delayTime;
    public float spawnAmount;
}