using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reiniciar : MonoBehaviour
{
    public void Reiniciar()
    {
        SceneManager.LoadScene("SampleScene");
        scoretext.scoreValue = 0;
        Time.timeScale = 1f;
    }
}
