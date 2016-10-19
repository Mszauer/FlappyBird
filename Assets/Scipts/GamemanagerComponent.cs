using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class GamemanagerComponent : MonoBehaviour {
    public enum GameState { Playing,Dead,Start};
    public GameState currentState = GameState.Start;

    public void SwitchState(GameState newState) {
        if (currentState == newState) {
            return;
        }
        currentState = newState;
    }


}
