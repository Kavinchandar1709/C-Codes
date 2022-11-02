using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placer : MonoBehaviour
{
    public GameObject engine;
    public GameObject truck;
    public GameObject wire;
    public GameObject wheels;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void engineplace()
    {
        if (engine.activeInHierarchy == true)
        {
            truck.SetActive(true);
            engine.SetActive(false);
            wire.SetActive(false);
            wheels.SetActive(false);
        }

        else
        {
            engine.SetActive(true);
            truck.SetActive(false);
            wire.SetActive(false);
            wheels.SetActive(false);
        }


    }

    public void wireplace()
    {
        if (wire.activeInHierarchy == true)
        {
            truck.SetActive(true);
            wire.SetActive(false);
            engine.SetActive(false);
            wheels.SetActive(false);
        }


        else
        {
            wire.SetActive(true);
            truck.SetActive(false);
            engine.SetActive(false);
            wheels.SetActive(false);
        }
    }

    public void wheelsplace()
    {
        if(wheels.activeInHierarchy == true)
        {
            truck.SetActive(true);
            engine.SetActive(false);
            wheels.SetActive(false);
            wire.SetActive(false);  
        }
        else
        {
            wheels.SetActive(true);
            truck.SetActive(false);
            engine.SetActive(false);
            wire.SetActive(false);
        }
    }
}
