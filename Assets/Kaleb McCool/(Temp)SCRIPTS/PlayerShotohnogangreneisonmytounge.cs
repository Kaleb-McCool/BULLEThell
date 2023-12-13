using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShotohnogangreneisonmytounge : MonoBehaviour
{
    public PlayerShotohnogangreneisonmytounge bulletPrefab;
    public Collider2D target;
    public GameObject bowlet;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerShotohnogangreneisonmytounge p =  Instantiate(bulletPrefab, transform.position, Quaternion.identity);                   
        p.bulletSpeed = ((bowlet.gameObject.transform.position - transform.position).normalized * 7);
    }
}
