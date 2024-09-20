using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class LetterController : MonoBehaviour
{
    public Transform player;
    public bool canPickup;
    /*private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && Keyboard.current.eKey.wasPressedThisFrame)
        {
            transform.SetParent(player);
            transform.position = new Vector2(player.position.x, player.position.y + 1);
        }
    }*/
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            canPickup = true;
        }
    }

    private void Update()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame)
    }
}
