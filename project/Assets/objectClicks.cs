using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectClicks : MonoBehaviour
{
    private bool etatF = true;
    private bool etatO = false;
    public GameObject instruction;

    // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
            if (Input.GetKeyDown(KeyCode.E))
            {
                Manage();
            }
        
    }
    public void Manage()
    {
        if (etatF)
        {
            instruction.SetActive(true);
            etatF = false;
            etatO = true;
        }
        else if (etatO)
        {
            instruction.SetActive(false);
            etatF = true;
            etatO = false;
        }
    }

    
}
