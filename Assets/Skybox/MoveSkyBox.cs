using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSkyBox : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time*speed); // Rotate the skybox with the speed
    }
}
