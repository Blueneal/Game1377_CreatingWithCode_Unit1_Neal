using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField]
    private Transform playerTransform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = playerTransform.position;
        transform.position = playerTransform.position;
    }
}
