using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public int moveNum;
    public float timerMax;

    public float moveTimer;

    public bool hasMoved;
    // Start is called before the first frame update
    void Start()
    {
        timerMax = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (moveTimer > 0)
        {
            moveTimer -= Time.deltaTime;
        }
        if (moveTimer <= 0)
        {
            hasMoved = false;
            moveNum = Random.Range(1, 3);
        }

        if (hasMoved == false)
        {
            //if (moveNum = 1)
            {
                //move it to same x at line 1
            }

           // if (moveNum = 2)
            {
                //move it to same x at line 2
            }

           // if (moveNum = 3)
            {
                //move it to same x at line 3
            }
        }
        
    }
}
