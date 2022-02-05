using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{

    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("Game closed");
    }

    public void Update()
    {
        // if(Input.GetMouseButtonDown(0))
        // {
        //     QuitButton();
            
        // }
    }
}
