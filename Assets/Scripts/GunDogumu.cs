using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunDogumu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(new Vector3(250f,0f,250f),Vector3.right,0.2f*Time.deltaTime);
    }
}
