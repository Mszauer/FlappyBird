using UnityEngine;
using System.Collections;

public class JumpComponent : MonoBehaviour {
    public float impulse = 200.0f;
    private Rigidbody2D body2D;
    bool jumping = false;

    void Awake() {
        body2D = GetComponent<Rigidbody2D>();
    }

    void Update() {
        if (Input.anyKeyDown) {
            if (!jumping) {
                jumping = true;
                body2D.AddForce(new Vector2(0, impulse), ForceMode2D.Impulse);
            }
        }

        jumping = false;
    }
}
