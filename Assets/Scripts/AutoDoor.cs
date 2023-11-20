using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDoor : MonoBehaviour
{
    [SerializeField] Transform door;
    [SerializeField] float openTime;
    [SerializeField] float openDoorHeight;
    [SerializeField] BoxCollider boxCollider;

    float timer = Mathf.Infinity;
    bool opening;
    bool closing;

    private void Update()
    {
        if (opening)
        {
            timer += Time.deltaTime;
            if (timer >= openTime)
            {
                timer = openTime;
                opening = false;
            }
            float doorPositionY = Mathf.Lerp(0, openDoorHeight, timer/openTime);
            door.transform.localPosition = new Vector3(0, doorPositionY, 0);
        }

        else if (closing)
        {
            timer += Time.deltaTime;
            if (timer >= openTime)
            {
                timer = openTime;
                closing = false;
            }
            float doorPositionY = Mathf.Lerp(openDoorHeight, 0, timer / openTime);
            door.transform.localPosition = new Vector3(0, doorPositionY, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + " entered door trigger");
        StartUpMove();
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.name + " exited door trigger");
        StartDownMove();
    }

    void StartUpMove()
    {
        closing = false;
        opening = true;
        timer = 0;
    }

    void StartDownMove()
    {
        opening = false;
        closing = true;
        timer = 0;
    }
}
