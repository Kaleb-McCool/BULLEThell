using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bowlIsTable : MonoBehaviour
{
    public Vector2 bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(bulletSpeed*Time.deltaTime);
    }
}
