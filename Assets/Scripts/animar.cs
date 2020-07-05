using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animar : MonoBehaviour
{

    private Animator controlador;

    void Start()
    {
        controlador = this.GetComponent<Animator>();   
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            controlador.SetBool("andando", true);
        }
        else {
            controlador.SetBool("andando", false);
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            controlador.SetTrigger("chutando");
        }
    }
}
