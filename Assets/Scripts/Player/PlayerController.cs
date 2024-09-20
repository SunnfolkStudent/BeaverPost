using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private InputActions _input;
    public float moveSpeed = 5f;
    public int points = 0;

    public Rigidbody2D _rigidbody2D;
    
    
    void Start()
    {
        _input = GetComponent<InputActions>();
        
    }

    private void FixedUpdate()
    {
        _rigidbody2D.linearVelocity = _input.Movement * moveSpeed;
    }

    
    void Update()
    {
        

    }
}