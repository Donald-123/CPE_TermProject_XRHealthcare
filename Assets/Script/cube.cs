using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {

        transform.position = transform.position + Time.deltaTime * transform.forward * 3; //The position of the cube is updated at the speed of 4m/s
    }
}
