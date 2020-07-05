using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class identificarColisao : MonoBehaviour
{

    private AudioSource audio;
    public AudioClip acerto;
    public AudioClip erro;
    public GameObject placar;

    void Start() {
        audio = this.GetComponent<AudioSource>();
    }


    void OnTriggerEnter(Collider outro) {
        print(outro.name);
        if (outro.name == "dentro") {
            placar.GetComponent<ControlarPlacar>().totalGols++;
            audio.clip = acerto;
            audio.Play();
            StartCoroutine("Restart");
        }
        else if (outro.name == "fora")
        {
            placar.GetComponent<ControlarPlacar>().totalErros++;
            audio.clip = erro;
            audio.Play();
            StartCoroutine("Restart");
        }
    }

    IEnumerator Restart()
    {
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
