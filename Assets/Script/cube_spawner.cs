using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_spawner : MonoBehaviour
{
    public GameObject[] cubes; //access the list of cube objects to break
    public Transform[] points; //Access the position of the cubes being spawned 
    public float speed = (60 / 105); //The speed at which the cube is spawned
    public float timer; //time remaining between spawning of the cubes
    // Update is called once per frame

    // Update is called once per frame
    void Update()
    {
     if(timer > speed) //when there is time remaining, which means cubes can be spawned more within the given time interval
        {
            GameObject cube = Instantiate(cubes[Random.Range(0, 2)], points[Random.Range(0, 4)]); //cube is randomly instantiated between red and blue cubes at random position
            cube.transform.localPosition = Vector3.zero; //Setting the local position of the cube to center
            cube.transform.Rotate(transform.forward, 90 * Random.Range(0, 4)); //Add rotation to the cube at 90 degree
            timer -= speed; //decrement the time remaining to control the time between the cube spawns
        }
        timer += Time.deltaTime; //Increase the timer by time passed since the last frame. In this way, blocks are continuously spawned 
    }
}
