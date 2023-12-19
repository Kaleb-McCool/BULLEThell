using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    // Start is called before the first frame update
    public bowlIsTable bowlt;

    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            bowlIsTable p =  Instantiate(bowlt, transform.position, Quaternion.identity);                   
            p.bulletSpeed = ((Player.gameObject.transform.position - transform.position).normalized * 7);
        }
       
    }
}
