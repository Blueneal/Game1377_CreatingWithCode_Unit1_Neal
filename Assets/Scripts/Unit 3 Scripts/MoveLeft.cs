using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 20;
    private float leftBound = -15;

    private PlayerControllerUnit3 PlayerControllerUnit3Script;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerControllerUnit3Script = GameObject.Find("Player").GetComponent<PlayerControllerUnit3>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerControllerUnit3Script.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
