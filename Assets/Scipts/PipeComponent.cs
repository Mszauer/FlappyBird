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
    public void changeHeight(float dY) {
        topPipe.transform.position = new Vector3(topPipe.transform.position.x, pipePositions[Random.Range(0,pipePositions.Count)]+pipeHeight);
    }
    
}