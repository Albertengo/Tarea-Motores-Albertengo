using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoretext : MonoBehaviour
{
    public static int scoreValue = 0;
    public TextMeshProUGUI textoCantidadRecolectados;

    void Start()
    {
        textoCantidadRecolectados = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        textoCantidadRecolectados.text = "Puntaje: " + scoreValue;
    }
}
