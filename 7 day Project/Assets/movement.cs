using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

public class movement : MonoBehaviour
{

    public float speed = 0;
    public Sprite[] sprites;
    private bool isCoroutineRunning = false;
    
    IEnumerator ChangeSprites()
    {
        isCoroutineRunning = true;
        int i = 1;
        while (Input.GetKey(KeyCode.W))
        {
            GetComponent<SpriteRenderer>().sprite = sprites[i];
            i = 3 - i;
            yield return new WaitForSeconds(0.15f);
        }
        isCoroutineRunning = false;
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W)) {
            if (!isCoroutineRunning) {
                StartCoroutine(ChangeSprites());
            }
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
        }

        else {
            GetComponent<SpriteRenderer>().sprite = sprites[0];
        }
    }
}