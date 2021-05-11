using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlay : MonoBehaviour
{
    public Animator anim;

    void Update()
    {
        anim.SetBool("Dance", true);
    }

}