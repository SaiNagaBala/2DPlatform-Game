using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineEffect : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name =="Player")
        {
            collision.collider.GetComponent<PlayerMovement>().SuperJump();
        }
    }
}
