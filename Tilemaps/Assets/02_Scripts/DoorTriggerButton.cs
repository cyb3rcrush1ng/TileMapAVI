using System.Collections;
using UnityEngine;

public class DoorTriggerButton : MonoBehaviour
{

    [SerializeField] private DoorSetActive door;
    [SerializeField] private float time;

    public void Update()
    {

        StartCoroutine(nameof(OpenDoorEvent));
        
    }

    public IEnumerator OpenDoorEvent()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            door.OpenDoor();
            yield return new WaitForSeconds(time);
            door.CloseDoor();
        }
    }
}