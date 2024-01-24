using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

public class movement : MonoBehaviour
{

    public float speed = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W)) {
            if (Input.GetKey(KeyCode.A)) {
                transform.position += new Vector3(-speed * 6 / 10, speed * 6 / 10, 0) * Time.deltaTime;
            } else if (Input.GetKey(KeyCode.D)) {
                transform.position += new Vector3(speed * 6 / 10, speed * 6 / 10, 0) * Time.deltaTime;
            } else {
                transform.position += new Vector3(0, speed, 0) * Time.deltaTime;
            }
        }

        else if (Input.GetKey(KeyCode.S)) {
            if (Input.GetKey(KeyCode.A)) {
                transform.position += new Vector3(-speed * 6 / 10, -speed * 6 / 10, 0) * Time.deltaTime;
            } else if (Input.GetKey(KeyCode.D)) {
                transform.position += new Vector3(speed * 6 / 10, -speed * 6 / 10, 0) * Time.deltaTime;
            } else {
                transform.position += new Vector3(0, -speed, 0) * Time.deltaTime;
            }
        }

        else if (Input.GetKey(KeyCode.A)) {
            transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.D)) {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime; // afk
        };

    }
}