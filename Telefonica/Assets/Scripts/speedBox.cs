using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedBox : MonoBehaviour
{
    public GameObject cajaSpawner;
    private Rigidbody rb;
    private Spawner scriptSpawner;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        scriptSpawner = cajaSpawner.GetComponent<Spawner>();
    }

    // Update is called once per frame
    void Update()
    {
            rb.velocity = new Vector3(0.2f, 0, 0);
        if (scriptSpawner.isPaused)
        {
            rb.isKinematic = true;
        }
        else
        {
            rb.isKinematic = false;
        }
        //InvokeRepeating("Pause", 1f, 10f);
        //InvokeRepeating("Resume", 1f, 14f);

    }

    //void Pause()
    //{
    //    rb.isKinematic = true;
    //    //Time.timeScale = 0;
    //}

    //void Resume()
    //{
    //    rb.isKinematic = false;
    //    //Time.timeScale = 1;
    //}

}
