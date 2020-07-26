using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageManager : MonoBehaviour
{
    // 스테이지 매니저 싱글톤
    public static StageManager instance;
    private void Awake()
    {
        StageManager.instance = this;
    }

    // 현재 스테이지 스코어
    int currentScore = 0;

    // 필드에 아이템 몇개인지
    public int currentFieldItem = 0;

    public Text count;
    public int weaponCount;

    private void Start()
    {
        GameStart();
    }

    private void Update()
    {
        count.text = weaponCount.ToString();
    }


    // 게임 시작하면 무조건 해야하는 것들 델리게이트로 연결
    // UI 치우기 같은거
    // 오브젝트 스폰 같은거
    public void GameStart()
    {
        Spawn();
        LevelManager.instance.SpawnWeapon();
        weaponCount--;
    }

    public void Finish()
    {

        if(weaponCount <= 0)
        {
            Debug.Log("Lose");
            return;
        }

        // 오브젝트를 모두 파괴 했다면
        if (currentFieldItem <= 0)
        {
            // 다음 레벨 스폰
            // 조건에 따라서 스폰 알고리즘 다른거 실행
            Spawn();
            LevelManager.instance.SpawnWeapon();
        }
        // 오브젝트가 남았다면
        else
        {
            weaponCount--;
            LevelManager.instance.SpawnWeapon();
        }
        
    }

    public void DecreaseFieldItem()
    {
        if(currentFieldItem > 0)
        {
            currentFieldItem--;
        }
    }

    private void Spawn()
    {
        LevelManager.instance.MakeLevel();
        
    }

    public void AddScroe(int score)
    {
        currentScore += score;
    }


}
