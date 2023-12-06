using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
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
            moveNum = Random.Range(2, 7);
        }

        if (hasMoved == false)
        {
            if (ycooord <max)
            {
                transform.Translate(Vector3.y+moveNum);
            }
            else
            {
                transform.Translate(Vector3.y-moveNum);
            }

            hasMoved = true;
        }
        
    }
}
