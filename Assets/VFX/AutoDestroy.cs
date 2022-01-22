using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    public float time;
    public IEnumerator DestroyAfterTime()
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
    public void Start()
    {
        StartCoroutine(DestroyAfterTime());
    }
}
