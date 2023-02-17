using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float mseed;
    Vector3 mvelocity;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mvelocity = Vector3.zero;


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -0.2f, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0.2f, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            mvelocity.z = 1.0f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            mvelocity.z = -1.0f;
        }

        if (Input.GetKey(KeyCode.W))
        {

            mvelocity.x = 1.0f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            mvelocity.x = -1.0f;
        }

        transform.Translate(mvelocity.normalized * Time.deltaTime * mseed);


    }
}