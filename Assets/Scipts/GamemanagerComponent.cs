using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GamemanagerComponent : MonoBehaviour {
    public enum GameState { Playing,Dead,Start};
    public GameState currentState = GameState.Start;

    public Text currentScore;
    public Text startText;
    public Text deadText;
    public static GamemanagerComponent Instance {
        get {
            return instance;
        }
    }

    private static GamemanagerComponent instance;

    void Awake() {
        instance = this;


        if (currentState == GameState.Start) {
            startText.enabled = true;
            deadText.enabled = false;
        }
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

    public void ReloadScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
