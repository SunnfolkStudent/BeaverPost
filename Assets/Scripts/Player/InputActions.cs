using UnityEngine;

public class InputActions : MonoBehaviour
{
    private InputSystem_Actions _inputSystem;

    public Vector2 Movement;

    private void Update()
    {
        Movement = _inputSystem.Player.Move.ReadValue<Vector2>();
    }

    private void Awake() { _inputSystem = new InputSystem_Actions(); }

    private void OnEnable() { _inputSystem.Enable(); }

    private void OnDisable() { _inputSystem.Disable(); }
}