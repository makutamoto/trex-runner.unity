using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaboFactoryBehaviour : MonoBehaviour
{
    public GameObject sabo;
    Text scoreObject;
    int score;

    void updateScore() {
        scoreObject.text = string.Format("Score: {0, 5}", score);
    }

    void SpawnSabo() {
        if(Random.Range(0f, 1f) < 0.5f) Instantiate(sabo, this.transform.position, this.transform.rotation);
        score += 5;
        updateScore();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnSabo", 0f, 1f);
        scoreObject = GameObject.Find("Score").GetComponent<Text>();
        updateScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
