
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fist : MonoBehaviour
{
    // Start is called before the first frame update
    public LayerMask layer;
    public int scoreup = 0;
    private Vector3 previousPos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {       
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, 1, layer))
        {
            
            if (Vector3.Angle(transform.position - previousPos, hit.transform.up) > 125)
            {
                Destroy(hit.transform.gameObject);
                ScoreManager.instance.ScoreUp();
            }
        }  
        previousPos = transform.position;
    }
}



