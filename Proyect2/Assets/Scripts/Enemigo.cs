using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private float velocidad;

    [SerializeField] private int da�o;

    [SerializeField] private float tiempoDeVida;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<CombajeJugador>().TomarDa�o(da�o);
            Destroy(gameObject);

            SceneManager.LoadScene("Muerte");
        }
    }


}
