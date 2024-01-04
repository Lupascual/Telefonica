using UnityEngine;

public class ControlCintaTransportadora : MonoBehaviour
{
    public GameObject cajaPrefab;   // Prefab de la caja
    public Transform puntoInicio;   // Punto en la parte superior de la rampa

    void Start()
    {
        // Llama a la funci�n InstanciarCaja cada 2 segundos despu�s de 1 segundo de espera inicial
        InvokeRepeating("InstanciarCaja", 1f, 2f);
    }

    void InstanciarCaja()
    {
        // Crea una nueva instancia de la caja en el punto de inicio
        GameObject nuevaCaja = Instantiate(cajaPrefab, puntoInicio.position, Quaternion.identity);

        // Accede al componente Rigidbody para ajustar la velocidad
        Rigidbody rb = nuevaCaja.GetComponent<Rigidbody>();

        // Ajusta la velocidad seg�n tus necesidades
        rb.velocity = new Vector3(0, -1, 0);
    }
}
