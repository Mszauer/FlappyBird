using UnityEngine;
using System.Collections;

public class CollisionComponent : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D coll) {
        //Debug.Log("Collision Detected, Game Over");
        GamemanagerComponent.Instance.SwitchState(GamemanagerComponent.GameState.Dead);
    }
}
