using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShotohnogangreneisonmytounge : MonoBehaviour
{
    public PlayerShotohnogangreneisonmytounge bowlt;
    public GameObject bowlet;
    public Vector2 bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
             PlayerShotohnogangreneisonmytounge p =  Instantiate(bowlt, transform.position, Quaternion.identity);                   
                    p.bulletSpeed = ((bowlet.gameObject.transform.position - transform.position).normalized * 7);
        }
       
    }
}
