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
            //Instantiate(ForwardCar in lane 1);
            //Instantiate(forwardCar in lane 4);
            doEnemySpawn = false;
        }

        if (gm.waveNum == 2 && doEnemySpawn == true)
        {
            //Instantiate(TrackingCar in Lane 2)
            //Instantiate(TrackingCar in Lane 3)
            doEnemySpawn = false;
        }
        if (gm.waveNum == 3 && doEnemySpawn == true)
        {
            //Instantiate(ForwardCar in Lane 1)
            //Instantiate(ForwardCar in Lane 2)
            //Instantiate(TrackingCar in Lane 4)
            doEnemySpawn = false;
        }
        if (gm.waveNum == 4 && doEnemySpawn == true)
        {
            //Instantiate(3ShotCar in Lane 2)
            //Instantiate(3ShotCar in Lane 3)
            doEnemySpawn = false;
        }if (gm.waveNum == 5 && doEnemySpawn == true)
        {
            //Instantiate(ForwardCar in Lane 1)
            //Instantiate(TrackingCar in Lane 2)
            //Instantiate(3ShotCar in Lane 3)
            doEnemySpawn = false;
        }if (gm.waveNum == 6 && doEnemySpawn == true)
        {
            //Instantiate(TrackingCar in Lane 1)
            //Instantiate(TrackingCar in Lane 2)
            //Instantiate(TrackingCar in Lane 3)
            //Instantiate(ForwardCar in Lane 4)
            doEnemySpawn = false;
        }if (gm.waveNum == 7 && doEnemySpawn == true)
        {
            //Instantiate(ForwardCar in Lane 1)
            //Instantiate(ForwardCar in Lane 2)
            //Instantiate(ForwardCar in Lane 3)
            //Instantiate(TrackingCar in Lane 4
            doEnemySpawn = false;
        }if (gm.waveNum == 8 && doEnemySpawn == true)
        {
            //Instantiate(TrackingCar in Lane 1)
            //Instantiate(TrackingCar in Lane 2)
            //Instantiate(TrackingCar in Lane 3)
            //Instantiate(TrackingCar in Lane 4)
            doEnemySpawn = false;
        }
        if (gm.waveNum == 9 && doEnemySpawn == true)
        {
            //Instantiate(ForwardCar in Lane 1)
            //Istantiate(3TrackingCar in Lane 2)
            //Istantiate(3TrackingCar in Lane 3)
            //Instantiate(ForwardCar in Lane 4
            doEnemySpawn = false;
        }if (gm.waveNum == 10 && doEnemySpawn == true)
        {
           //Instantiate(Boss in Lane 2)
            doEnemySpawn = false;
        }
        
    }
}
