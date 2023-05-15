using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxisRaw("Vertical");

        float moveY = verticalInput * Mathf.Cos(45 * Mathf.Deg2Rad);

        Vector3 movement = new Vector3(0.0f, moveY, 0.0f);

        transform.position += movement * speed * Time.deltaTime;
    }
}
