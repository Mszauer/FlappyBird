using UnityEngine;
using System.Collections;

public class JumpComponent : MonoBehaviour {
    public float jumpForce = 200.0f;
    private Rigidbody2D body2D;
    public float gravity = -100.0f;

    float currentForce;

    void Awake() {
        body2D = GetComponent<Rigidbody2D>();
        currentForce = gravity;
    }

    void Update() {
        body2D.velocity = new Vector2(0, currentForce);

        if (Input.anyKeyDown) {
            currentForce = jumpForce;
        }
        currentForce += gravity * Time.deltaTime * 2.0f;
        if (currentForce < gravity) {
            currentForce = gravity;name 
        }
    }
}
