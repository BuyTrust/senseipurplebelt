using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Shape objects")] public GameObject[] shapePrefabs;
    [Header("Default spawn delay time")] public float spawnDelay = 2f;
    [Header("Default spawn time")] public float spawnTime = 3f;
    [Header("game ove rui object")] public GameObject gameOverCanvas;
    void Start()
    {
        InvokeRepeating("Spawn", spawnDelay, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Spawn()
    {
        int randomInt = Random.Range(0, shapePrefabs.Length);
        Instantiate(shapePrefabs[randomInt], Vector3.zero, Quaternion.identity);
    }
    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        CancelInvoke("Spawn");
        Time.timeScale = 0;
    }
}
