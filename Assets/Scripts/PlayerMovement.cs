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
        if (player.Input.Movement.y > 0 && player.Input.Movement.x == 0)
        {
            Vector3 rotation = transform.eulerAngles;
            rotation.y = Camera.main.transform.eulerAngles.y;

            player.Rigidbody.MoveRotation(Quaternion.Euler(rotation));
        }

        Vector3 movement = transform.forward * player.Input.Movement.y * movementSpeed * Time.deltaTime
            + transform.right * player.Input.Movement.x * movementSpeed * Time.deltaTime;

        player.Rigidbody.MovePosition(transform.position + movement);

        


        
    }
}
