using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class PipeComponent : MonoBehaviour {
    public GameObject topPipe;
    public List<float> pipePositions;
    public bool scorable = true;

    protected float pipeHeight = 0.0f;

    void Awake() {
        pipeHeight = topPipe.GetComponent<Image>().rectTransform.rect.height/2;
    }
    public void changeHeight() {
        int pipeIndex = Random.Range(0, pipePositions.Count);
        topPipe.transform.position = new Vector3(topPipe.transform.position.x, 0f, 0f);
        topPipe.transform.localPosition = new Vector3(topPipe.transform.localPosition.x, pipePositions[pipeIndex], 0.0f);
        //Debug.Log("Get index: " + pipeIndex + ", Position: " + pipePositions[pipeIndex] + ", Height: " + pipeHeight + " Final: " + (pipePositions[pipeIndex] + pipeHeight));
    }
    
}