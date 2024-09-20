    using System;
    using UnityEngine;
    using UnityEngine.InputSystem;

    public class LetterController : MonoBehaviour
    {
        private InputActions _input;
        public Transform player;
        public bool canPickup = false;

        public bool isHoldingPost = false;

        void Start()
        {
            _input = player.GetComponent<InputActions>();
        }
     
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                canPickup = true;
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
            }
            else if (isHoldingPost == true && _input.interact)
            {
                transform.SetParent(null);
                transform.position = new Vector2(player.position.x + (1 * player.localScale.x), player.position.y);
                isHoldingPost = false;
            }
        }
    }
