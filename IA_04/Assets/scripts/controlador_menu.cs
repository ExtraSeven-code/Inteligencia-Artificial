using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class controlador_menu : MonoBehaviour
{
    public TextMeshProUGUI texto_score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score();
    }

    public void boton_jugar()
    {
        SceneManager.LoadScene("juego");
    }
    public void boton_salir()
    {
        Application.Quit();
    }
    public void score()
    {
        string puntaje = PlayerPrefs.GetString("puntaje", "");
        texto_score.text = "SCORE: " + puntaje;
    }
}
