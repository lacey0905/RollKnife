using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    // 레벨 매니저 싱글톤
    public static LevelManager instance;
    private void Awake()
    {
        LevelManager.instance = this;
    }

    // 스테이지 오브젝트 종류
    public List<GameObject> objects = new List<GameObject>();

    // 웨폰 종류
    public Weapon weapon;

    private void Start() 
    {
        // 웨폰 데이터 가져와서 현재 선택한 웨폰으로 갈아 끼워야 함
    }

    public void MakeLevel()
    {
        Vector2 objPos = GetObejctStating();
        Vector2 weaponPos = GetWeaponStarting();

        if (objPos.x < 0f)
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
