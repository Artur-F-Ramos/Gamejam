using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    private Rigidbody2D rb;

    public GameObject playerSpawnPoint;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector2(94.6f, 37.2f); // Set the spawn point position
    }

    void Update()
    {
        // Get both horizontal and vertical input
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        // Create movement vector
        Vector2 movement = new Vector2(moveHorizontal, moveVertical).normalized;

        // Apply movement
        rb.linearVelocity = movement * moveSpeed;
    }
}