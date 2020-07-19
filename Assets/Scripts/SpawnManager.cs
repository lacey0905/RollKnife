using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public static SpawnManager instance;
    public Knife knife;

    private void Awake()
    {
        SpawnManager.instance = this;
    }

    private void Start()
    {
        Spawn();
    }

    public GameObject target;

    Vector3 curSpawnPos;

    public void Spawn()
    {
        curSpawnPos = new Vector3(Random.Range(-2f, 2f), 3.5f, 0f);
        Invoke("WaitSpawn", 0.5f);
    }

    void WaitSpawn()
    {
        Instantiate(target, curSpawnPos, Quaternion.identity);
        knife.KnifeShooting();
    }
    

}
