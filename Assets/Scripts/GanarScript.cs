using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GanarScript : MonoBehaviour
{

    void Start()
    {
        gameObject.SetActive(false);
    }

    
    public void ActiveScreen()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0f;
    }
    
}
