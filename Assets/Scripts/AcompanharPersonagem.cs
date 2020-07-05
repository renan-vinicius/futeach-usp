using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcompanharPersonagem : MonoBehaviour
{
    public Transform personagem;
    private Vector3 velocity = Vector3.zero;
    public Vector3 distancia;

    void Update() {
        Vector3 novaPosicao = personagem.position + distancia;
        Vector3 interpolacao = Vector3.SmoothDamp(this.transform.position, novaPosicao, ref velocity, 0.5f);
        this.transform.position = interpolacao;
    }
}
