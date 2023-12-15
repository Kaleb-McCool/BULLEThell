using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bowlIsTable : MonoBehaviour
{
    public Vector2 bulletSpeed;
    public float bulletlifetime;

    public float maxbulletlifetime;
    // Start is called before the first frame update
    void Start()
    {
        maxbulletlifetime = 5.0f;
        bulletlifetime = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(bulletSpeed*Time.deltaTime);
        if (bulletlifetime <= 0)
        {
            bulletlifetime = maxbulletlifetime;
            Destroy(gameObject);
        }
        if (bulletlifetime > 0)
        {
            bulletlifetime = bulletlifetime - Time.deltaTime;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            Destroy(other);
        }
    }
}

