using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class collision_beber : MonoBehaviour
{
    public bool puede_beber = false;
    public GameObject bocanada_agua;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (puede_beber && Input.GetMouseButtonDown(0))
        {
            bocanada_agua.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Agua"))
        {
            puede_beber=true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Agua"))
        {
            puede_beber=false;
        }
    }

}
