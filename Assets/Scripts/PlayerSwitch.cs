using UnityEngine;

public class PlayerSwitch : MonoBehaviour
{
    public AudioClip audioClip;
    private AudioSource audioSource;

    public GameObject otherPlayer;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip;
    }
    private void OnMouseDown()
    {
        otherPlayer.GetComponent<PlayerMovement>().enabled = false;
        GetComponent<PlayerMovement>().enabled = true;
        audioSource.Play();
    }

}
