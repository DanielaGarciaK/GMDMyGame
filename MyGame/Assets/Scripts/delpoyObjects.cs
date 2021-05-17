using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delpoyObjects : MonoBehaviour
{
    [SerializeField]
    private Transform[] spawnPoints;
    [SerializeField]
    private GameObject[] elemprefab;
    [SerializeField]
    private float respawnTime;

    // Start is called before the first frame update
    void Start()
    {
        //screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(prefWave());
    }
    private void spawnPrefab()
    {
        int randPrefab = Random.Range(0, elemprefab.Length);
        GameObject e = Instantiate(elemprefab[randPrefab]) as GameObject;
        //e.transform.SetParent(GameObject.Find("coin").transform);

        //e.transform.parent = transform;
        int randSpawnPoint = Random.Range(0, spawnPoints.Length);
        e.transform.position = spawnPoints[randSpawnPoint].position;
    }

    IEnumerator prefWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnPrefab();
        }
       
    }
}
