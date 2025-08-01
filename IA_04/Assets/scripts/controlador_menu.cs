using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class controlador_menu : MonoBehaviour
{
    public TextMeshProUGUI texto_score;
    public TextMeshProUGUI mejor_score;
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
        int puntaje = PlayerPrefs.GetInt("puntaje" );
        int mejor_puntaje = PlayerPrefs.GetInt("mejor_puntaje");
        
        texto_score.text = "SCORE: " + puntaje;
        if(puntaje > mejor_puntaje)
        {
            mejor_puntaje = puntaje;
            PlayerPrefs.SetInt("mejor_puntaje", mejor_puntaje); 
            PlayerPrefs.Save();
            
        }
        mejor_score.text = "BEST SCORE: " + mejor_puntaje;
    }
}
