using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageController : MonoBehaviour
{

    public static StageController instance;

    private void Awake()
    {
        StageController.instance = this;
    }

    public List<LevelStat> levels = new List<LevelStat>();

    LevelStat curLevel = null;

    public void newStage(int stage)
    {
        if (curLevel != null)
        {
            Destroy(curLevel.gameObject);
        }
        LevelStat t = Instantiate(levels[stage], transform.position, Quaternion.identity) as LevelStat;
        curLevel = t;
    }

    public Vector3 newStageStarting(int stage)
    {
        return levels[stage].starting;
    }


}
