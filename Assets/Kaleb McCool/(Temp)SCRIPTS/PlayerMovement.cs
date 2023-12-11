using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float xWalkingSpeed;
    public float xDirection;
    public float xVector;
    // Start is called before the first frame update
    void Start()
    {
        xWalkingSpeed = 4;
    }

    // Update is called once per frame
    void Update()
    {
        
        xDirection = Input.GetAxis("Horizontal");
        
        xVector = xDirection * xWalkingSpeed * Time.deltaTime;
        
        transform.position = transform.position + new Vector3(xVector, 0, 0);
    }
}
