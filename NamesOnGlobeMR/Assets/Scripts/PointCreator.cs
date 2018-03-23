using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCreator : MonoBehaviour
{

    public GameObject point;
    

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(point, transform.position, transform.rotation);
            
        }
    }
}