using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [field: SerializeField] public PlayerMovement Movement { get; private set; }
    [field: SerializeField] public InputReader Input { get; private set; }
    [field: SerializeField] public Rigidbody Rigidbody { get; private set; }
    [field: SerializeField] public Animator Animator { get; private set; }
    [field: SerializeField] public CinemachineFreeLook Camera { get; private set; }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
