using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class HorizontalScrollingComponent : MonoBehaviour {
    public ScoreComponent scoreKeeper;
    public List<GameObject> objects;
    public float moveSpeed = 1.0f;
    public float deltaY;

    protected List<float> xOffset;
    void Awake() {
        xOffset = new List<float>();
        foreach (GameObject obj in objects) {
            xOffset.Add(obj.GetComponent<Image>().rectTransform.rect.width / 2);
        }
    }
	// Update is called once per frame
	void Update () {
	    for (int i = 0; i < objects.Count; i++) {
            //move x pos
            objects[i].transform.position = new Vector2(objects[i].transform.position.x - moveSpeed*Time.deltaTime, objects[i].transform.position.y);

            PipeComponent pipes = objects[i].GetComponent<PipeComponent>();

            if (pipes != null && pipes.scorable && objects[i].transform.position.x + xOffset[i] < (Screen.width/2-10)) {//offset  because player isn't centered
                scoreKeeper.AddPoints(1);
                pipes.scorable = false;
            }

            if (objects[i].transform.position.x+xOffset[i] < 0) {
                float xPos = Screen.width + xOffset[i];
                if (pipes != null) {
                    pipes.changeHeight(deltaY);
                    pipes.scorable = true;
            }
            objects[i].transform.position = new Vector2(xPos, objects[i].transform.position.y);
            }
        }
    }
}
