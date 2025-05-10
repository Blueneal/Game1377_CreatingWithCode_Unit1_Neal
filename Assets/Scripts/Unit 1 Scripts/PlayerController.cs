using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float vehicleSpeed;

    [SerializeField]
    private float turnSpeed;

    [SerializeField]
    private float horizontalInput;

    [SerializeField]
    private float verticalInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(vehicleSpeed * Vector3.forward * Time.deltaTime * verticalInput);  
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
        
    }
}
