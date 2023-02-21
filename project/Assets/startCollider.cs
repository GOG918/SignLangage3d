using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startCollider : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject instruction;
    public GameObject instruction2;
    public GameObject instruction3;
    public GameObject instruction4;
    public GameObject instruction5;
    public GameObject instruction6;
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "panelBeginning")
        {
            instruction.SetActive(true);
        }
        if(other.tag == "Cubechoice")
        {
            instruction2.SetActive(true);
            instruction5.SetActive(true);
        }
        if (other.tag == "CubeChoice2")
        {
            instruction3.SetActive(true);
            instruction6.SetActive(true);
        }
        if (other.tag == "fin")
        {
            instruction4.SetActive(true);
        }

    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "panelBeginning")
        {
            instruction.SetActive(false);
        }
        if(other.tag == "Cubechoice")
        {
            instruction2.SetActive(false);
            instruction5.SetActive(false);
        }
        if (other.tag == "CubeChoice2")
        {
            instruction3.SetActive(false);
            instruction6.SetActive(false);
        }
        if (other.tag == "fin")
        {
            instruction4.SetActive(false);
        }
    }

    
}
