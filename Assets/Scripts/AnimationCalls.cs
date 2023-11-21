using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCalls : MonoBehaviour
{
    Player player;

    private void Start()
    {
        player = GetComponentInParent<Player>();
    }

    public void Throw()
    {
        player.SmokeBombThrower.Throw();
    }

}
