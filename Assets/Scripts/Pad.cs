using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad : MonoBehaviour
{
    public GameObject player2;
    public GameObject pad;
    public GameObject obstacle;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player2"))
        {
            obstacle.active = false;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        obstacle.active = true;
    }
}
