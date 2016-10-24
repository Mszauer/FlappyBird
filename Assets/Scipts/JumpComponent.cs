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
        if (GamemanagerComponent.Instance.currentState == GamemanagerComponent.GameState.Start) {
            if (Input.anyKeyDown) {
                GamemanagerComponent.Instance.SwitchState(GamemanagerComponent.GameState.Playing);
            }
        }
        if (GamemanagerComponent.Instance.currentState == GamemanagerComponent.GameState.Playing) {
            body2D.velocity = new Vector2(0, currentForce);

            if (Input.anyKeyDown) {
                currentForce = jumpForce;
            }
            currentForce += gravity * Time.deltaTime * 2.0f;
            if (currentForce < gravity) {
                currentForce = gravity;
            }
            OutOfBounds();
        }
        if (GamemanagerComponent.Instance.currentState == GamemanagerComponent.GameState.Dead) {
            if (Input.anyKeyDown) {
                GamemanagerComponent.Instance.ReloadScene();
            }
        }
    }

    public void OutOfBounds() {
        if (body2D.transform.position.y > Screen.height || body2D.transform.position.y < 0) {
            //Debug.Log("Out of Bounds, Game Over");
            GamemanagerComponent.Instance.SwitchState(GamemanagerComponent.GameState.Dead);
        }
    }
}
