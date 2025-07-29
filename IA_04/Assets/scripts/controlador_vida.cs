using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class controlador_vida : MonoBehaviour
{
    public int vida_pacman;
    private bool invulnerable = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("fantasma") && !invulnerable)
        {
            vida_pacman -= 1;
            Debug.Log("meni 1 vida");
            StartCoroutine(tiempo_invulnerable());
        }
        if (vida_pacman <= 0)
        {
            Destroy(gameObject);
        }
    }
    IEnumerator tiempo_invulnerable()
    {
        invulnerable = true;
        yield return new WaitForSeconds(1f);
        invulnerable = false ;
    }
}
