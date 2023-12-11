using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class WaveSpawner : MonoBehaviour
{
    public GM gm;
    public readonly int[] spawns;
    public int vector3;

    public bool doEnemySpawn;
    // Start is called before the first frame update
    void Start()
    {
        gm.waveNum = 0;
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
            //spawn wave 1 enemies
            doEnemySpawn = false;
        }

        if (gm.waveNum == 2 && doEnemySpawn == true)
        {
            //spawn wave 2 enemies
            doEnemySpawn = false;
        }
        //etc until final boss wave
    }
}
