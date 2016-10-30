using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreComponent : MonoBehaviour {
    public Text scoringText;
    protected int score;

    public void AddPoints(int amt) {
        score += amt;
        updateText();
    }

    protected void updateText() {
        scoringText.text = score.ToString();
    }
    public void resetScore() {
        score = 0;
        updateText();
    }
}
