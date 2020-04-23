using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float rotationSpeed = 3;
    void Update()
    {
        float hMove = Input.GetAxis("Horizontal");
        float vMove = Input.GetAxis("Vertical");
        
        transform.Rotate(0, hMove * rotationSpeed, 0);
    }
}
