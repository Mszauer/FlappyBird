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

        currentScore.text = PlayerPrefs.GetInt("BestScore").ToString();

        if (currentState == GameState.Start) {
            startText.enabled = true;
            deadText.enabled = false;
        }
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

    public void ReloadScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Shutdown();
    }
}
