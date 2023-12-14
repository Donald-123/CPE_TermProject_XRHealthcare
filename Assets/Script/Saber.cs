
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saber : MonoBehaviour
{
    // Start is called before the first frame update
    public LayerMask layer; //Retreive the layer value
    public int scoreup = 0; //variable to store the score
    private Vector3 previousPos; //variable to store the previous position

    // Update is called once per frame
    void Update()
    {       
        RaycastHit hit; //create raycast object
        if(Physics.Raycast(transform.position, transform.forward, out hit, 1, layer)) //send the ray forward with distance 1 from the current position and only consider the object with layer
        {
            
            if (Vector3.Angle(transform.position - previousPos, hit.transform.up) > 125)
            {
                Destroy(hit.transform.gameObject); //destory the hit object
                ScoreManager.instance.ScoreUp(); // increment the point
            }
        }  
        previousPos = transform.position; //
    }
}



