using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFewSecond : MonoBehaviour
{
    public float second = 1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyFewSeconds());
    }

    IEnumerator DestroyFewSeconds()
    {
        yield return new WaitForSeconds(second);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
