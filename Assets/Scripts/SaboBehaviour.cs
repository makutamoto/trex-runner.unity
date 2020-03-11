using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaboBehaviour : MonoBehaviour
{
    Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        body = this.GetComponent<Rigidbody2D>();
        body.velocity = new Vector3(-5f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.x < -15f) Destroy(this.gameObject); 
    }
}
