using UnityEngine;

public class Box_Spawn : MonoBehaviour
{
    public GameObject SquareBox;
    public GameObject TriangleBox;
    public GameObject CircleBox;
    private GameObject RandomSpawnObject;

    public Vector3 SpawnPoint;



    public float SpawnInterval = 20;
    float timer;
    float timerColor;

    private float spawnAmount = 2;
    private float RandomSpawn = 0;
    public Score ScoreCounter;

    // Update is called once per frame
    void Update()
    {
        RandomSpawnThing();
        SpawnIncreaser();

        timer += Time.deltaTime;
        if (timer >= SpawnInterval)
        {

            for (int i = 0; i < spawnAmount; i++)
            {
                Instantiate(RandomSpawnObject, SpawnPoint, Quaternion.identity);
                RandomSpawn = 0;

            }

            timer = 0;

        }

    }

    private void RandomSpawnThing()
    {
        if (RandomSpawn == 0)
        {

            RandomSpawn = Random.Range(0, 4);
            if (RandomSpawn == 1)
            {
                RandomSpawnObject = SquareBox;
            }
            if (RandomSpawn == 2)
            {
                RandomSpawnObject = TriangleBox;
            }
            if (RandomSpawn == 3)
            {
                RandomSpawnObject = CircleBox;
            }
        }
    }

    private void SpawnIncreaser()
    {
        if (ScoreCounter.score > 250 && ScoreCounter.score < 500) 
        {
            spawnAmount = 3;
        }
        if (ScoreCounter.score > 500 && ScoreCounter.score < 750) 
        {
            spawnAmount = 4;
        }
        if (ScoreCounter.score > 750 && ScoreCounter.score < 1000)
        {
            spawnAmount = 5;
        }
        if (ScoreCounter.score > 1250 && ScoreCounter.score < 1500)
        {
            spawnAmount = 6;
        }
        if (ScoreCounter.score > 1500 && ScoreCounter.score < 1750) 
        {
            spawnAmount = 7;
        }
        if (ScoreCounter.score > 1750 && ScoreCounter.score < 2000) 
        {
            spawnAmount = 8;
        }
        if (ScoreCounter.score > 2000 && ScoreCounter.score < 2500)
        {
            spawnAmount = 9;
        }
        if (ScoreCounter.score > 2500)
        {
            spawnAmount = 10;
        }
        if (ScoreCounter.score > 5000)
        {
            spawnAmount = 20;
        }
    }
}

