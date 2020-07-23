using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public float throwPower;
    public float firePower;
    public float torque;

    Rigidbody2D rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        Throw();
        Turn();
        StartCoroutine("WeaponUpdate");
    }

    IEnumerator WeaponUpdate()
    {
        // 0.5초 뒤에 업데이트 실행
        yield return new WaitForSeconds(0.5f);
        while(true)
        {

            // 발사 키 입력 받기
            if(Input.GetMouseButtonDown(0))
            {
                Fire();
            }


            // 스테이지 종료 조건 체크
            IsEscape();

            yield return null;
        }
    }

    private void Throw()
    {
        rigidbody.gravityScale = 1f;
        rigidbody.AddForce(Vector2.up * throwPower, ForceMode2D.Impulse);
    }

    private void Fire()
    {
        rigidbody.gravityScale = 0f;
        rigidbody.angularVelocity = 0f;
        rigidbody.AddForce(transform.up * firePower, ForceMode2D.Impulse);
    }

    private void Turn()
    {
        rigidbody.AddTorque(torque);
    }
    
    private void IsEscape()
    {
        float posX = transform.position.x;
        float posY = transform.position.y;

        // 맵을 벗어남
        if(posX < -4f || posX > 4f || posY < -6f || posY > 6f)
        {
            // 파괴함
            Destroy(this.gameObject);

            // 스테이지를 종료함
            StageManager.instance.Finish();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 오브젝트가 필드 아이템이면 파괴 플로우 호출
        collision.GetComponent<FieldItem>().ItemDestroy();
    }


}
