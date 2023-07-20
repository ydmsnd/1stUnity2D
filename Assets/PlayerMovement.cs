using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            {
                Rigidbody2D playersRB = GetComponent<Rigidbody2D>();
                playersRB.AddForce(Vector2.up * 200f);
            }
        if(Input.GetKeyDown(KeyCode.D))
            {
                Rigidbody2D playersRB = GetComponent<Rigidbody2D>();
                playersRB.AddForce(Vector2.right * 200f);
            }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Rigidbody2D playersRB = GetComponent<Rigidbody2D>();
            playersRB.AddForce(Vector2.left * 200f);
        }

        //Debug.Log(keypressed);
    }
}
