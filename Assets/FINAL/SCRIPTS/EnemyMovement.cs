using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float timerMax;
    public int moveNum;
    public float moveTimer;
    public float loc1;
    public float loc2;
    public float loc3;
    public bool hasMoved = true;
    // Start is called before the first frame update
    void Start()
    {
        timerMax = 2.0f;
        moveTimer = timerMax;
        loc1 = 1;
        loc2 = 2;
        loc3 = 3;

    }

    // Update is called once per frame
    void Update()
    {
        if (hasMoved == true)
        {
            moveTimer -= Time.deltaTime;
        }
        if (moveTimer <= 0)
        {
            moveNum = Random.Range(1, 3);
            hasMoved = false;
        }

        if (hasMoved == false)
        {
            if (moveNum == 1)
            {
                transform.position = new Vector3(transform.position.x, loc1, transform.position.z);
                hasMoved = true;
                moveTimer = timerMax;
            }

            if (moveNum == 2)
            {
                transform.position = new Vector3(transform.position.x, loc2, transform.position.z);                hasMoved = true;
                moveTimer = timerMax;
            }

            if (moveNum == 3)
            {
                transform.position = new Vector3(transform.position.x, loc3, transform.position.z);
                hasMoved = true;
                moveTimer = timerMax;
            }
        }
    }
}
