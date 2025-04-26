using UnityEngine;

public class Walkable : MonoBehaviour 
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private float force = 2f;
    private const float ForcePower = 10f;
    
    public Rigidbody2D rb2d;
    
    private Vector2 direction;
    
    private void Awake()
    {
        if (rb2d == null) rb2d = GetComponent<Rigidbody2D>();
    }
    
    public void MoveTo(Vector2 direction) 
    {
        this.direction = direction.normalized;
    }
    
    public void Stop() 
    {
        MoveTo(Vector2.zero);
    }
    
    private void FixedUpdate() 
    {
        Vector2 desiredVelocity = direction * speed;
        Vector2 deltaVelocity = desiredVelocity - rb2d.linearVelocity;
        Vector2 force = deltaVelocity * (this.force * ForcePower * Time.fixedDeltaTime);
        rb2d.AddForce(force);
    }
}