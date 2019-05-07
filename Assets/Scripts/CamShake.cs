using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamShake : MonoBehaviour {

    public Animator camAnim;
    //Function to set the trigger animation of the camera movement from left to right every time the character get hit by an enemie
    public void shake()
    {
        camAnim.SetTrigger("shake");
    }
    //Function to set the trigger animation of the camera movement from up to down every time the character move
    public void move()
    {
        camAnim.SetTrigger("move");
    }
}
