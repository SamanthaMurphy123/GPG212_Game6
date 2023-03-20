using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public static GameObject p1obstacle;
    public static GameObject pad;
    public GameObject player1;
    public static GameObject player2;
    public GameObject startPoint;

    public static bool isActive;

    private void Start()
    {
        isActive = false;
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player1") && isActive == false)
        {
            player1.transform.position = startPoint.transform.position;
        }
    }

    



}
