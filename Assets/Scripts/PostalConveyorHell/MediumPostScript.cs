using UnityEngine;

public class MediumPostScript : MonoBehaviour
{
 private InputActions _input;
        public Transform player;
        public bool canPickup = false;

        public bool isHoldingPost = false;
        public bool wasPickedUp;
        
        public Rigidbody2D rb;

        public float speed = 10f;

        public Vector3 direction;

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            player = GameObject.FindGameObjectWithTag("Player").transform;
            _input = player.GetComponent<InputActions>();
            
            
        }
     
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                canPickup = true;
            }
            
            //this is to simulate a conveyor lets see how this goes
            if (other.CompareTag("Left"))
            {
                direction = new Vector2(-1,0);
            }

            if (other.CompareTag("Right"))
            {
                direction = new Vector2(1, 0);
            }

            if (other.CompareTag("Up"))
            {
                direction = new Vector2(0, 1);
            }

            if (other.CompareTag("Down"))
            {
                direction = new Vector2(0, -1);
            }

            if (other.CompareTag("Out"))
            {
                print("out");
                // player.score -= scoreValue;
            }

            if (other.CompareTag("MediumPostDelivery"))
            {
                wasPickedUp = false;
                direction = new Vector2(-1, 0);
            }

            if (other.CompareTag("Destroy"))
            {
                Destroy(gameObject);
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                canPickup = false;
            }
        }

        private void Update()
        {
            if (canPickup == true && _input.interact)
            {
                transform.SetParent(player);
                transform.position = new Vector2(player.position.x, player.position.y + 1);
                print("hi");
                isHoldingPost = true;
                canPickup = false;
                rb.linearVelocity = Vector2.zero;
                wasPickedUp = true;
            }
            else if (isHoldingPost == true && _input.interact)
            {
                transform.SetParent(null);
                transform.position = new Vector2(player.position.x + (1 * player.localScale.x), player.position.y);
                isHoldingPost = false;
            }
        }

        private void FixedUpdate()
        {
            if (wasPickedUp == false)
            {
                rb.linearVelocity = direction * speed;
            }
        
        }
}
