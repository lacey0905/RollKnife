using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{

    Rigidbody2D rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private bool isFire = false;
    private bool isShooting = false;

    public float power;

    Vector3 direction = Vector3.zero;
    public float rotSpeed;

    public float shootingPower;

    public GameObject eft;

    public SceneCamera camera;
    
    private void Update()
    {
        
        if(Input.GetMouseButtonDown(0))
        {
            if (!isFire)
            {
                Stop();
                Fire();
                rigidbody.gravityScale = 1.0f;
            }
            else
            {
                Shooting();
            }
        }
        else if (Input.GetMouseButtonDown(1))
        {
            Stop();
        }

        if(!isShooting)
        {
            direction = new Vector3(direction.x, direction.y, direction.z + rotSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(direction);
        }
        else
        {
            transform.position += transform.up * shootingPower * Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {
        
    }

    private void Shooting()
    {
        isFire = false;
        isShooting = true;
        rigidbody.gravityScale = 0f;
        rigidbody.velocity = Vector2.zero;

        Instantiate(eft, transform.position, Quaternion.identity);

    }

    private void Fire()
    {
        isFire = true;
        rigidbody.AddForce(Vector3.up * power, ForceMode2D.Impulse);
    }

    private void Stop()
    {
        isFire = false;
        isShooting = false;
        rigidbody.velocity = Vector2.zero;
        rigidbody.gravityScale = 0f;
        transform.position = new Vector3(0f, -6f, 0f);
        transform.rotation = Quaternion.Euler(Vector3.zero);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(eft, collision.transform.position, Quaternion.identity);
        Destroy(collision.gameObject);
        camera.Shake();
    }


}
