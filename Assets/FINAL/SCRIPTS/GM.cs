using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GM : MonoBehaviour
{
    
    private static GM gm;
    public int health;
    public int bulletCount;
    public int waveNum;
    public int enemiesLeft;
    public TextMeshProUGUI bulletCountText;
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
        bulletCountText.text = "Bullets:" + bulletCount;
    }
}
