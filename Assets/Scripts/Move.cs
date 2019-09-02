using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //float h = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-2, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
			transform.Translate(new Vector3(2, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
			transform.Translate(new Vector3(0, 2, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
			transform.Translate(new Vector3(0, -2, 0) * Time.deltaTime);
        }

    }
}
