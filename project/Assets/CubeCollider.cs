using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollider : MonoBehaviour
{
    public Animator anim;

    private void OnCollisionStay(Collision collision)
    {
        
        if(collision.collider.tag == "CubeChoice1")
        {
            anim.Play("smallbridge90");
        }
        if (collision.collider.tag == "CubeChoice3")
        {
            anim.Play("largeBridge90");
        }

    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "CubeChoice1")
        {
            anim.Play("smallbridge0");
        }
        if (collision.collider.tag == "CubeChoice3")
        {
            anim.Play("largeBridge0");
        }

    }


}
