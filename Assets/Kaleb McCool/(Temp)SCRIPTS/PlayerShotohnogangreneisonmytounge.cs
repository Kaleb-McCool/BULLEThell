using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShotohnogangreneisonmytounge : MonoBehaviour
{
    public bowlIsTable bowlt;

    public GameObject bowlet;

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
                    p.bulletSpeed = ((bowlet.gameObject.transform.position - transform.position).normalized * 7);
        }
       
    }
}
