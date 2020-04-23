using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3;
    public float rotationSpeed = 3;

    void Update()
    {
        float hMove = Input.GetAxis("Horizontal");
        float vMove = Input.GetAxis("Vertical");
        
        transform.Rotate(0, hMove * rotationSpeed, 0);

        CharacterController controller = GetComponent<CharacterController>();
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        controller.SimpleMove(forward * vMove * speed);
    }
}
