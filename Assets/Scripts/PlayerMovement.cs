using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Player player;
    [SerializeField] float movementSpeed;


    private void Awake()
    {
        player = GetComponent<Player>();
    }

    private void Update()
    {
        player.Animator.SetFloat("forward", player.Input.Movement.y);
        player.Animator.SetFloat("right", player.Input.Movement.x);

        
    }

    private void FixedUpdate()
    {
        Vector3 movement = transform.forward * player.Input.Movement.y * movementSpeed * Time.deltaTime
            + transform.right * player.Input.Movement.x * movementSpeed * Time.deltaTime;
        player.Rigidbody.Move(transform.position + movement, transform.rotation);
    }
}
