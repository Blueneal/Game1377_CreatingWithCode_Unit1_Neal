using UnityEngine;

public class SpawnManagerUnit3 : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 1, 0);

    private float startDelay = 2;
    private float repeatRate = 2;

    private PlayerControllerUnit3 PlayerControllerUnit3Script;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        PlayerControllerUnit3Script = GameObject.Find("Player").GetComponent<PlayerControllerUnit3>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if (PlayerControllerUnit3Script.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }
}
