using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldItem : MonoBehaviour
{
    
    // 아이템 파괴 플로우
    public void ItemDestroy()
    {
        Destroy(this.gameObject);
        // 이펙트 생성 등등
        // 스테이지 매니저에게 파괴가 됐으니 카운트를 감소 시키라고 함
        // 스코어도 증가 시킴

        StageManager.instance.DecreaseFieldItem();


    }


}
