using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float jumpForce = 300f;
    private bool shouldJump;

    private void Awake() => rb = GetComponent<Rigidbody2D>();
    void Update()
    {
        if (shouldJump == false)
            shouldJump = Input.GetButtonDown("Fire1");
    }

    private void FixedUpdate()
    {
        if (shouldJump)
        {
            rb.AddForce(jumpForce * Vector3.up);
            shouldJump = false;
        }
    }
}
