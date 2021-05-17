using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemie : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;
    public float speed = 10.0f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        if (speed <= 0)
        {
            int randEnemy = Random.Range(0, enemyPrefabs.Length);
            int randSpawPoint = Random.Range(0, spawnPoints.Length);

            Instantiate(enemyPrefabs[randEnemy], spawnPoints[randSpawPoint].position, transform.rotation);
        }
        else
        {
            speed -= Time.deltaTime;
        }
    }
}
