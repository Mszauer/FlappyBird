using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class GamemanagerComponent : MonoBehaviour {
    public enum GameState { Playing,Dead,Start};
    public static GameState currentState = GameState.Start;

    public Text currentScore;
    public Text startText;
    public Text deadText;

    void Awake() {
        currentScore.text = PlayerPrefs.GetInt("BestScore").ToString();
    }
    void Shutdown() {
        PlayerPrefs.SetInt("BestScore", System.Convert.ToInt32(currentScore.text));
    }

    public void SwitchState(GameState newState) {
        if (currentState == newState) {
            return;
        }
        currentState = newState;
        if (currentState == GameState.Start) {
            startText.enabled = true;
            deadText.enabled = false;
        }
        else if (currentState == GameState.Playing) {
            startText.enabled = false;
            deadText.enabled = false;
        }
        else if (currentState == GameState.Dead) {
            deadText.enabled = true;
            startText.enabled = false;
        }
    }


}
