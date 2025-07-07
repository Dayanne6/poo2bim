
using System;
using TMPro;
using UnityEngine;

public class TextoRandomizado : MonoBehaviour
{
    public string novoTexto;
    public TextMeshProUGUI UITexto;
    
    public int numero;

    private void Start()
    {
        UITexto.text = novoTexto + "  " + numero;
    }
    
    if (Input.GetKeyDown(KeyCode.Z))
    {
        numero++;
        
    }  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
