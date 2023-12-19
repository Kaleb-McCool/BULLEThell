using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class WaveSpawner : MonoBehaviour
{
    public GM gm;
    public int numNUms;
    public int vector3;
    public GameObject ForwardShotCar;
    public GameObject TrackingShotCar;
    public GameObject ThreeShotCar;

    public bool doEnemySpawn;
    // Start is called before the first frame update
    void Start()
    {
        gm.waveNum = 0;
        gm.enemiesLeft = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.enemiesLeft == 0)
        {
            gm.waveNum += 1;
            doEnemySpawn = true;
        }

        if (gm.waveNum == 1 && doEnemySpawn == true)
        {
            Instantiate(ForwardShotCar, new Vector3(0, 0), Quaternion.identity);
            Instantiate(ForwardShotCar, new Vector3(1, 0), Quaternion.identity);
            doEnemySpawn = false;
        }

        if (gm.waveNum == 2 && doEnemySpawn == true)
        {
            Instantiate(TrackingShotCar, new Vector3(0, 0), Quaternion.identity);
            Instantiate(TrackingShotCar, new Vector3(1, 0), Quaternion.identity);
            doEnemySpawn = false;
        }
        if (gm.waveNum == 3 && doEnemySpawn == true)
        {
            //Instantiate(ForwardShotCar, transform. in Lane 1, Quaternion.identity);
            //Instantiate(ForwardShotCar, transform. in Lane 2, Quaternion.identity);
            //Instantiate(TrackingShotCar, transform. in Lane 4, Quaternion.identity);
            doEnemySpawn = false;
        }
        if (gm.waveNum == 4 && doEnemySpawn == true)
        {
            //Instantiate(ThreeShotCar, transform. in Lane 2, Quaternion.identity);
            //Instantiate(ThreeShotCar, transform. in Lane 3, Quaternion.identity);
            doEnemySpawn = false;
        }
        if (gm.waveNum == 5 && doEnemySpawn == true)
        {
            //Instantiate(ForwardShotCar, transform. in Lane 1, Quaternion.identity);
            //Instantiate(TrackingCar, transform. in Lane 2, Quaternion.identity);
            //Instantiate(ThreeShotCar, transform. in Lane 3, Quaternion.identity);
            doEnemySpawn = false;
        }
        
    }
}
