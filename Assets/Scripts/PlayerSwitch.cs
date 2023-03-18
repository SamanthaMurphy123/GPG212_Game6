using UnityEngine;

public class PlayerSwitch : MonoBehaviour
{

    public GameObject otherPlayer;

    private void OnMouseDown()
    {
        otherPlayer.GetComponent<PlayerMovement>().enabled = false;
        GetComponent<PlayerMovement>().enabled = true;
    }

}
