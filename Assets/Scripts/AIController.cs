using UnityEngine;

public class AIController : MonoBehaviour
{
    [SerializeField]
    private float vehicleSpeed;

    [SerializeField]
    private float lifeTime = 5.0f;

    [SerializeField]
    private int[] speedArray = {10, 15, 20};

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RandomVehicleSpeed();
        Destroy(this.gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime *  vehicleSpeed);
    }

    private void RandomVehicleSpeed()
    {
        vehicleSpeed = Random.Range(10, speedArray.Length);
    }
}
