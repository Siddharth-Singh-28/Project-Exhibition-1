using System.Collections;
using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    public Animation glass_panel_1_with_door;
    public float openDuration = 2.0f; // Time to keep the door open in seconds
    private bool playerNear = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = true;
            glass_panel_1_with_door.Play("Open"); // Play the opening animation
            StartCoroutine(CloseDoor());
        }
    }

    private IEnumerator CloseDoor()
    {
        yield return new WaitForSeconds(openDuration);
        glass_panel_1_with_door.Play("Close"); // Play the closing animation
        playerNear = false;
    }
}
