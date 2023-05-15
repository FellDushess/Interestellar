using UnityEngine;

public class EnemyIA : MonoBehaviour
{
    public float speed = 3f; // velocidad de movimiento del enemigo
    public float yLimit = 3f; // límite de movimiento vertical

    private float direction = 1f; // dirección de movimiento (1 hacia arriba, -1 hacia abajo)

    void Update()
    {
        // movimiento vertical del enemigo
        float y = transform.position.y + speed * direction * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, y, transform.position.z);

        // cambio de dirección al detectar colisión con un objeto llamado "Wall"
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, 0.5f);
        foreach (var hitCollider in hitColliders)
        {
            if (hitCollider.gameObject.CompareTag("Wall"))
            {
                direction *= -1f;
                break;
            }
        }
    }
}
