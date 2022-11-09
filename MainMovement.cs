using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMovement : MonoBehaviour
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
        mvelocity =  Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            mvelocity.z = 1.0f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            mvelocity.z = -1.0f;
        }

        if (Input.GetKey(KeyCode.D))
        {

            mvelocity.x = 1.0f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            mvelocity.x = -1.0f;
        }

        transform.Translate(mvelocity.normalized * Time.deltaTime * mseed );

        
    }
}
