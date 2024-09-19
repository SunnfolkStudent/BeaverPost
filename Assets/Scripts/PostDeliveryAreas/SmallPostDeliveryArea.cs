using UnityEngine;

public class SmallPostDeliveryArea : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            print(collision.gameObject.name + " delivered small sized package");
        }
    }
}
