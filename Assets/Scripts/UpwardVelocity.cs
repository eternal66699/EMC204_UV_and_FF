using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpwardVelocity : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform target;
    public float gravityScale = 1f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = gravityScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            float distanceToTarget = target.position.y - transform.position.y;

            float upwardVelocity = Mathf.Sqrt(2 * Mathf.Abs(Physics2D.gravity.y) * distanceToTarget);

            rb.velocity = new Vector2(0, upwardVelocity);
        }
    }
}
