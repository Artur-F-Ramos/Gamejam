using UnityEngine;

public class Character : MonoBehaviour 
{
    [SerializeField] private Transform target;
    [SerializeField] private Walkable walkable;
    [SerializeField] private float minDistance = 0.5f;
    
    private void Awake()
    {
        if (walkable == null) walkable = GetComponent<Walkable>();
    }
    
    private void Update() 
    {
        if (target == null) return;
        
        Vector2 toTarget = target.position - transform.position;
        float distance = toTarget.magnitude;
        
        if (distance > minDistance)
        {
            walkable.MoveTo(toTarget.normalized);
        }
        else
        {
            walkable.Stop();
        }
    }
}