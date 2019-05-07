using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharHurt : MonoBehaviour {

    public Animator charAnim;
    public void shake()
    {
        charAnim.SetTrigger("hurt");
    }
}
