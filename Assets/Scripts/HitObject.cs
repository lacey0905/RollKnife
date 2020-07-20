using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitObject : MonoBehaviour
{
    public ObjectBreak obj;
    public GameObject eft;

    public void ObjectBreak()
    {
        Instantiate(obj, transform.position, Quaternion.identity);
        Instantiate(eft, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }

    public float spawnSpeed;
    float scaleCount = 0f;

    private void Update()
    {
        scaleCount += Time.deltaTime * spawnSpeed;
        if (scaleCount >= 1.0f)
        {
            scaleCount = 1.0f;
        }
        transform.localScale = new Vector3(scaleCount, scaleCount, 1f);
    }

}
