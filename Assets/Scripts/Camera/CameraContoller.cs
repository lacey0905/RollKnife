using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContoller : MonoBehaviour
{
    public float duration;
    public float magnitude;

    public static CameraContoller instance;

    private void Awake()
    {
        CameraContoller.instance = this;
    }

    public void Shake()
    {
        StartCoroutine(Shake(duration, magnitude));
    }

    IEnumerator Shake(float duration, float magnitude)
    {
        Vector3 originPos = transform.localPosition;
        float elapsed = 0.0f;
        while (elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;
            transform.localPosition = new Vector3(x, y, originPos.z);
            elapsed += Time.deltaTime;
            yield return null;
        }
        transform.localPosition = Vector3.zero;
    }
}
