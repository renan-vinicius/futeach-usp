using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chutarBola : MonoBehaviour
{

    private bool proximoDaBola;
    private GameObject bola;

    void OnTriggerEnter(Collider outro) {
        if (outro.name == "bola") {
            proximoDaBola = true;
            bola = outro.gameObject;
        }        
    }

    void OnTriggerExit(Collider outro)
    {
        if (outro.name == "bola")
        {
            proximoDaBola = false;
        }
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && proximoDaBola) // se pressionar espaço
        {
            print("apertou espaço");
            bola.gameObject.GetComponent<Rigidbody>().AddForce(Random.Range(-30.0f, 30.0f), Random.Range(50.0f, 100.0f), Random.Range(50.0f, 100.0f)); // aplica força na bola para simular o chute
        }
    }
}
