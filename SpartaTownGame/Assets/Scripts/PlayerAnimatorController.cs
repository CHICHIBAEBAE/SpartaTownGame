using UnityEngine;

namespace Assets.Scripts
{
    internal class PlayerAnimatorController : MonoBehaviour
    {
        private Rigidbody2D movementRigidbody;
        [SerializeField] private Animator animator;
        Vector2 vector;




        private void Awake()
        {
            movementRigidbody = GetComponent<Rigidbody2D>();
            animator = GetComponent<Animator>();
        }

        private void Update()
        {
            PlayerMoveCheck();
        }
        private void PlayerMoveCheck()
        {
            bool PlayerSpeed = Mathf.Abs(movementRigidbody.velocity.magnitude) > Mathf.Epsilon;
            animator.SetBool("isRun", PlayerSpeed);
        }
            

    }
}
