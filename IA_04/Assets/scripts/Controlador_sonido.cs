using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador_sonido : MonoBehaviour
{
    [SerializeField] private AudioClip[] sonidos;
    private AudioSource controlador_audio;
    // Start is called before the first frame update
    void Start()
    {
        controlador_audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void seleccionar_audio(int indice, float volumen)
    {
        controlador_audio.PlayOneShot(sonidos[indice], volumen);
    }
}
