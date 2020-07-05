using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ControlarPlacar : MonoBehaviour
{
    public Text gols;
    public Text erros;
    public int totalGols;
    public int totalErros;

    // Update is called once per frame
    void Update()
    {
        gols.text = totalGols.ToString();
        erros.text = totalErros.ToString();
    }

}
