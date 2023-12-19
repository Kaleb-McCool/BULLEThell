using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShotohnogangreneisonmytounge : MonoBehaviour
{
    private GM gm;
    public bowlIsTable bowlt;
    public int maxBullet;
    public int bulletCount;
    public float reloading;
    public float reloadMax;
    public bool realod;
    
    public GameObject bowlet;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindObjectOfType<GM>();
        maxBullet = 12;
        bulletCount = maxBullet;
        realod = false;
        reloadMax = 2.0f;
        reloading = 2.0f;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && gm.bulletCount >= 1 && realod == false)
        {
             bowlIsTable p =  Instantiate(bowlt, transform.position, Quaternion.identity);                   
                    p.bulletSpeed = ((bowlet.gameObject.transform.position - transform.position).normalized * 7);
                    bulletCount--;
        }

        if (gm.bulletCount == 0 && realod == false)
        {
            
            realod = true;

        }
        if (realod)
        {
            reloading = reloading - Time.deltaTime;
        }

        if (reloading <= 0)
        {
            reloading = reloadMax;
            realod = false;
            gm.bulletCount = maxBullet;
        }
    }
}
