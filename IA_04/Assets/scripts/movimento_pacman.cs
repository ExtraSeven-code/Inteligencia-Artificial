using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento_pacman : MonoBehaviour
{
    Transform pacman_transform;
    CharacterController characterController;
    [SerializeField] private float horizontal;
    [SerializeField] private float vertical;
    [SerializeField] private int velocidad;
    [SerializeField] private int velocidad_rotacion;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        pacman_transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Euler(0f, 90f, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Euler(0f, -90f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }



    }
    private void FixedUpdate()
    {
        characterController.Move(new Vector3(horizontal, 0, vertical) * velocidad * Time.deltaTime);
    }
}
