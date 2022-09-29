using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Equipo : MonoBehaviour
{
    [SerializeField] private int dineroTotal = 200;
    [SerializeField] TextMeshProUGUI textoDinero;
    [SerializeField] GameObject objetoDeEquipo;

    private int numeroMaximoObjeto = 0;

    private void Start()
    {
        textoDinero.text = dineroTotal.ToString();
    }

    public void IncluirEquipo (int dinero, Image imagenEquipo)
    {
        if (dinero <= dineroTotal && numeroMaximoObjeto <= 4)
        {
            dineroTotal -= dinero;
            numeroMaximoObjeto++;
            GameObject equipo = GameObject.Instantiate(objetoDeEquipo, Vector2.zero, Quaternion.identity, GameObject.FindGameObjectWithTag("Equipo").transform);
            Image imagen = equipo.GetComponent<Image>();
            imagen.sprite = imagenEquipo.sprite;
            textoDinero.text = dineroTotal.ToString();
        }
    }
}
    
