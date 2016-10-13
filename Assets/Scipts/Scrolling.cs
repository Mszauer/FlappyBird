using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Scrolling : MonoBehaviour {
    public List<Image> objects;
    public float moveSpeed = 1.0f;
    public float deltaY;

    protected List<float> xOffset;
    void Awake() {
        xOffset = new List<float>();
        foreach (Image obj in objects) {
            xOffset.Add(obj.rectTransform.rect.width / 2);
        }
    }
	// Update is called once per frame
	void Update () {
	    for (int i = 0; i < objects.Count; i++) {
            //move x pos
            objects[i].transform.position = new Vector2(objects[i].transform.position.x - moveSpeed*Time.deltaTime, objects[i].transform.position.y);
            if (objects[i].transform.position.x+xOffset[i] < 0) {
                    float xPos = Screen.width + xOffset[i];
                    objects[i].transform.position = new Vector2(xPos, objects[i].transform.position.y);
                //if cobject child component<reset> != null
                //objectchild.resetY();
                //move y
                //bounds check top
                //move bottom
                //bottom bounds check
                //move y: resetY{+Random.Range(-deltaY,deltaY)};
            }
        }
    }
}
