using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
        scoretext.scoreValue = 0;
        Time.timeScale = 1f;
    }
}

