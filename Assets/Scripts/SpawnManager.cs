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

    bool isStart = false;

    private void Update()
    {
        if(!isStart)
        {
            if(Input.GetMouseButtonDown(0))
            {
                isStart = true;
                Spawn();
            }
        }
    }

    public void Spawn()
    {
        Invoke("WaitSpawn", 0.5f);
    }

    void WaitSpawn()
    {
        int newStage = Random.Range(0, 2);
        StageController.instance.newStage(newStage);
        Vector3 starting = StageController.instance.newStageStarting(newStage);
        knife.transform.position = starting;
        knife.KnifeShooting();
    }
    

}
