using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.U2D;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Rigidbody2D enemyRB;
    public float speed;
    bool isMovingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isMovingRight)
        {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
        }
        else
        {
            transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
        }

        if(transform.position.x >= 10)
        {
            isMovingRight = false;
        }

        if (transform.position.x <= -10)
        {
            isMovingRight = true;
        }
    }
}
