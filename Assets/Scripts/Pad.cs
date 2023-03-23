using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad : MonoBehaviour
{
    public GameObject player2;
    public GameObject pad;

    public GameObject[] obstacles;
    private void OnCollisionEnter2D(Collision2D other)
    {
        foreach (GameObject obj in obstacles)
        {
            obj.SetActive(false);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        foreach (GameObject obj in obstacles)
        {
            obj.SetActive(true);
        }
    }
}
