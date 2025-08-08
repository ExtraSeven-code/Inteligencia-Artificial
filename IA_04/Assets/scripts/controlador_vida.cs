using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlador_vida : MonoBehaviour
{
    public int vida_pacman;
    private bool invulnerable = false;
    private Controlador_sonido controlador_sonido;

    // Start is called before the first frame update
    void Start()
    {
        controlador_sonido = FindObjectOfType<Controlador_sonido>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("fantasma") && !invulnerable)
        {
            controlador_sonido.seleccionar_audio(0, 1);
            vida_pacman -= 1;
            Debug.Log("meni 1 vida");
            StartCoroutine(tiempo_invulnerable());
        }
        if (vida_pacman <= 0)
        {
            
            SceneManager.LoadScene("menu");
        }
    }
    IEnumerator tiempo_invulnerable()
    {
        invulnerable = true;
        yield return new WaitForSeconds(1f);
        invulnerable = false ;
    }
}
