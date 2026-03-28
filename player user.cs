using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;

    void Update()
    {
        float x = Input.GetAxis("Horizontal"); // A/D or Left/Right
        float z = Input.GetAxis("Vertical");   // W/S or Up/Down

        Vector3 move = transform.right * x + transform.forward * z;
        transform.Translate(move * speed * Time.deltaTime, Space.World);
    }
}