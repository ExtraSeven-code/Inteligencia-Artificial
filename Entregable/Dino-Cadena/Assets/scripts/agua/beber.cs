using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beber : MonoBehaviour
{
    public atributos_player atributos;
    public collision_beber collision_beber;
    public int cantidad_bocado_agua;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void beber_agua()
    {
        atributos.sed += cantidad_bocado_agua;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Agua"))
        {
            beber_agua();
            collision_beber.bocanada_agua.SetActive(false);
        }
    }
}
