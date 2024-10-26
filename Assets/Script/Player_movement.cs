using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
   
    public float speed = 6f;
    public bool move = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            move = true;
        }
        if(move)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.name);
    }
}
