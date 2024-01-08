using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject cajaPrefab;   // Prefab de la caja
    public Transform puntoInicio;   // Punto en la parte superior de la rampa

    void Start()
    {
        // Llama a la función InstanciarCaja cada 2 segundos después de 1 segundo de espera inicial
        InvokeRepeating("InstanciarCaja", 1f, 2f);
    }

    void InstanciarCaja()
    {
        // Crea una nueva instancia de la caja en el punto de inicio
        GameObject nuevaCaja = Instantiate(cajaPrefab, puntoInicio.position, Quaternion.identity);

        // Accede al componente Rigidbody para ajustar la velocidad
        Rigidbody rb = nuevaCaja.GetComponent<Rigidbody>();

        // Ajusta la velocidad y tamaño según tus necesidades
        rb.velocity = new Vector3(1, 0, 0);
        cajaPrefab.transform.localScale = new Vector3(Random.Range(0.25f, 0.5f), Random.Range(0.2f, 0.3f), Random.Range(0.25f, 0.4f));
    }
}

