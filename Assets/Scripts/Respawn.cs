using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject startPoint;
    public GameObject Player;

    public AudioClip audioClip;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip;
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            Player.transform.position = startPoint.transform.position;
            audioSource.Play();
        }
        
        if (other.gameObject.CompareTag("Player2"))
        {
            Player.transform.position = startPoint.transform.position;
            audioSource.Play();
        }
    }
}
