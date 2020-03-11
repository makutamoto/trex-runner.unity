using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class TREX : MonoBehaviour
{
    Rigidbody2D body;
    bool jump = false; 
    GameObject canvas;
    GameObject gameover;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        body = this.GetComponent<Rigidbody2D>();
        canvas = GameObject.Find("Canvas");
        gameover = canvas.transform.Find("GameOver").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)) EditorSceneManager.LoadScene("MainScene");
        if(jump && Input.GetKeyDown(KeyCode.Space)) {
            body.AddForce(new Vector3(0f, 10f, 0f), ForceMode2D.Impulse);
            jump = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.CompareTag("Floor")) jump = true;
    }

    void OnTriggerEnter2D(Collider2D collider) {
        if(collider.gameObject.CompareTag("Sabo")) {
            gameover.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
