using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaeDuRi : MonoBehaviour
{
    float rotationSpeed = 60;
    Vector3 CurrentEulerAngles;
    float z;
    public Transform pivotPoint;

    // Update is called once per frame
    void Update()
    {
        CurrentEulerAngles += new Vector3(0, 0, z) * Time.deltaTime * rotationSpeed;
        pivotPoint.localEulerAngles = CurrentEulerAngles;
    }

    public void TurnX()
    {
        z = -1;
    }
}
