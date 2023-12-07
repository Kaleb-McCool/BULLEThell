using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WaveSpawner : MonoBehaviour
{
    private TextMeshProUGUI WaveText;
    private int waveCount;
    private int enemyCount;
    private float waveTextTimer;
    private float spawnRate = 1.0f;
    private float timeBetweenWaves;

    [SerializeField] 
    private bool _isWaveActive = true;
    private bool _stopSpawning = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
