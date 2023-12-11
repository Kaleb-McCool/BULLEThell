using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
    private static GM gm;
    public int health;
    public int ammo;
    public int waveNum;
    public int enemiesLeft;
    void Awake()
    {
        if (gm != null && gm != this)
        {
           Destroy(gameObject); 
        }
        else
        {
            gm = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
