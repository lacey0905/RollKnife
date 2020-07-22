using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageManager : MonoBehaviour
{
    public static StageManager instance;

    public List<FieldObject> objects = new List<FieldObject>();

    public Knife weapon;

    int currentScore = 0;

    public GameObject UIScore;
    public GameObject start;

    public SceneCamera cam;

    private void Awake()
    {
        StageManager.instance = this;
    }
    
    public void GameStart()
    {
        UIScore.SetActive(true);
        start.SetActive(false);
        MakeLevel();
        UIScore.GetComponent<Text>().text = "0";
    }

    public void AddScroe(int score)
    {
        currentScore += score;
        UIScore.GetComponent<Text>().text = currentScore.ToString();
    }


    public void MakeLevel()
    {
        Vector2 objPos = GetObejctStating();
        Vector2 weaponPos = GetWeaponStarting();

        if(objPos.x < 0f)
        {
            weaponPos = new Vector2(Mathf.Abs(weaponPos.x), weaponPos.y);
        }
        else if (objPos.x > 0f)
        {
            weaponPos = new Vector2(Mathf.Abs(weaponPos.x) * -1f, weaponPos.y);
        }

        Instantiate(objects[0], objPos, Quaternion.identity);
        Instantiate(weapon, weaponPos, Quaternion.identity);
    }

    private Vector2 GetObejctStating()
    {
        return new Vector2(Random.Range(-2f, 2f), Random.Range(-4f, 4f));
    }

    private Vector2 GetWeaponStarting()
    {
        return new Vector2(Random.Range(-2.3f, 2.3f), -6f);
    }


}
