using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 650f;

    float movement;

    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -speed);
    }
}
