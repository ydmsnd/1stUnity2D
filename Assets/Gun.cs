using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject BulletTemplate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            mousePosition.z = 0;
            Quaternion test = Quaternion.Euler(0, 0, 30f);
            Instantiate(BulletTemplate, transform.position, test);
        }
    }
}
