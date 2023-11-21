using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeBombThrower : MonoBehaviour
{
    [SerializeField] SmokeBomb smokeBombPrefab;
    [SerializeField] float throwForce = 50f;
    Player player;

    private void OnEnable()
    {
        player = GetComponent<Player>();

        player.Input.Action += ThrowSmokeBomb;
    }

    private void ThrowSmokeBomb()
    {
        player.Animator.SetTrigger("throw");
    }

    public void Throw()
    {
        SmokeBomb smokeBomb = Instantiate(smokeBombPrefab, player.RightHand);
        smokeBomb.transform.parent = null;
        Vector3 force = (transform.forward + transform.up) * throwForce;
        smokeBomb.Rigidbody.AddForce(force);
    }
}
