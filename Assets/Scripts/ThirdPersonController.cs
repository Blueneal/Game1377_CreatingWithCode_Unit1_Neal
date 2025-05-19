using UnityEngine;

public class ThirdPersonController : MonoBehaviour
{
    private CharacterController controller;

    [SerializeField] private float speed = 5f;
    [SerializeField] private Camera playerCamera;
    [SerializeField] private Transform cameraArm;
    [SerializeField] private Animator animator;
    [SerializeField] private float yaw;
    [SerializeField] private float pitch;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<CharacterController>();
        playerCamera = GetComponentInChildren<Camera>();
        animator = GetComponent<Animator>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        yaw += mouseX;
        pitch -= mouseY;
        pitch = Mathf.Clamp(pitch, -30f, 60f);

        cameraArm.localRotation = Quaternion.Euler(pitch, 0, 0);
        transform.localRotation = Quaternion.Euler(0, yaw, 0);

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 inputDirection = new Vector3(horizontal, 0, vertical).normalized;
        if (inputDirection.magnitude >= .01f)
        {
            Vector3 moveDirection = transform.right * inputDirection.x + transform.forward * inputDirection.z;
            controller.Move(moveDirection.normalized * speed * Time.deltaTime);
        }

        animator.SetFloat("Move_X", inputDirection.normalized.x);
        animator.SetFloat("Move_Y", inputDirection.normalized.z);
    }
}
