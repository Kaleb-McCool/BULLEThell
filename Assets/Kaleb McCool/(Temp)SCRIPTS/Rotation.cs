using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float xDirection;
    public float reverseRotationSpeed;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        reverseRotationSpeed = -120.0f;
        rotationSpeed = 120.0f;
    }

    // Update is called once per frame
    void Update()
    {
        xDirection = Input.GetAxis("Horizontal");
        
        if (xDirection == 1)
        {
            transform.RotateAround(transform.position, Vector3.forward, rotationSpeed * Time.deltaTime);
        }

        if (xDirection == -1)
        {
            transform.RotateAround(transform.position, Vector3.forward, reverseRotationSpeed * Time.deltaTime);
        }
    }
}
