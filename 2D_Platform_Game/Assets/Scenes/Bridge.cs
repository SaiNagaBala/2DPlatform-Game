using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public float destroyTimer;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(DestroyBridge(destroyTimer));
    }
    private IEnumerator DestroyBridge(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);

    }
}
