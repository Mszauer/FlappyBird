using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreComponent : MonoBehaviour {
    protected int score;

    public void AddPoints(int amt) {
        score += amt;
        updateText();
    }

    protected void updateText() {
        gameObject.GetComponent<Text>().text = "Score: " + score.ToString();
    }
}
