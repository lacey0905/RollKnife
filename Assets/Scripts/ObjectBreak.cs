using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBreak : MonoBehaviour
{

    public List<Rigidbody2D> breaks = new List<Rigidbody2D>();

    private void Start()
    {
        for(int i=0; i < breaks.Count; i++)
        {
            Vector2 newDir = new Vector2(Random.Range(-6f, 6f), Random.Range(-6f, 6f));
            breaks[i].AddForce(newDir, ForceMode2D.Impulse);
        }
        Invoke("BreakDistroy", 1f);
    }

    private void BreakDistroy()
    {
        Destroy(this.gameObject);
    }

}
