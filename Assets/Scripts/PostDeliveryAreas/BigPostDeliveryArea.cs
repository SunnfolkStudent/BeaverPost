using UnityEngine;

public class BigPostDeliveryArea : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            print(collision.gameObject.name + " delivered big sized package");
        }
    }
}
