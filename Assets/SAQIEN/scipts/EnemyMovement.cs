using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public int moveNum;
    public float timerMax;

    public float moveTimer;
    public GameObject yLoc;
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
            moveNum = Random.Range(2, 7);
        }

        if (hasMoved == false)
        {
            if (yLoc.transform.position.y <-2)
            {
                transform.Translate(transform.position.x, yLoc.transform.position.y + moveNum, transform.position.z);
            }
            else
            {
                transform.Translate(transform.position.x, yLoc.transform.position.y - moveNum, transform.position.z);
            }

            hasMoved = true;
        }
        
    }
}
