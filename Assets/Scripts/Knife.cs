using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Knife : MonoBehaviour
{

    //public GameObject eft;
    //public GameObject hitEft;
    //public GameObject trail;

    //Rigidbody2D rigidbody;

    //public float upPower;
    //public float shootingPower;
    //public float torque;

    //Vector3 direction;
    //float coolTime;
    //bool isShooting = false;
    //bool isHit = false;


    //private void Awake()
    //{
    //    rigidbody = GetComponent<Rigidbody2D>();
    //}

    //private void Start()
    //{
    //    Up();
    //}

    //private void Update()
    //{
    //    coolTime += Time.deltaTime;
        

    //    if (Input.GetMouseButtonDown(0) && coolTime > 0.2f)
    //    {
    //        // 화면 터치
    //        Shooting();
    //    }

    //    if(coolTime > 3.0f && !isShooting)
    //    {
    //        HitCheck();
    //    }

    //    if(!isShooting)
    //    {
    //        Rotate();
    //    }

    //}

    //private void Up()
    //{
    //    rigidbody.gravityScale = 1.0f;
    //    rigidbody.AddForce(Vector2.up * upPower, ForceMode2D.Impulse);
    //}

    //private void Rotate()
    //{
    //    direction = new Vector3(0f, 0f, direction.z + torque * Time.deltaTime);
    //    transform.rotation = Quaternion.Euler(direction);
    //}

    //private void Shooting()
    //{
    //    trail.SetActive(true);
    //    Instantiate(eft, transform.position, Quaternion.identity);
    //    isShooting = true;
    //    rigidbody.gravityScale = 0f;
    //    rigidbody.velocity = transform.up * shootingPower * Time.deltaTime;
    //    Invoke("HitCheck", 1.0f);
    //}

    //private void HitCheck()
    //{
    //    if(isHit)
    //    {
    //        StageManager.instance.MakeLevel();
    //    }
    //    else if (!isHit)
    //    {
    //        SceneManager.LoadScene("EndPage");
    //    }
    //    Destroy(this.gameObject);
    //}

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    collision.GetComponent<FieldObject>().ObjectBreak();
    //    isHit = true;
    //    StageManager.instance.AddScroe(1);
    //    Instantiate(hitEft, collision.transform.position, Quaternion.identity);
    //}

}
