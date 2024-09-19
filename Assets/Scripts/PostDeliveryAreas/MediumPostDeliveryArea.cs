using UnityEngine;

public class MediumPostDeliveryArea : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            print(collision.gameObject.name + " delivered medium sized package");
        }
    }
}
