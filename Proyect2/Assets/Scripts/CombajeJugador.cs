using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CombajeJugador : MonoBehaviour
{
    [SerializeField] private int vida;

    public void TomarDaño(int cantidadDaño)
    {
        vida -= cantidadDaño;
        if (vida <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Muerte");

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
