using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombajeJugador : MonoBehaviour
{
    [SerializeField] private int vida;

    public void TomarDa�o(int cantidadDa�o)
    {
        vida -= cantidadDa�o;
        if (vida <= 0)
        {
            Destroy(gameObject);
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
