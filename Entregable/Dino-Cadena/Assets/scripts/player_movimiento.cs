using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class player_movimiento : MonoBehaviour
{
    public atributos_player atributo;
    public float vertical_movimiento;
    public float horizontal_movimiento;
    public CharacterController characterController;
    private Vector3 playerinput;

    public float playerspeed;
    private Vector3 playermovimiento;
    public float gravity = 9.8f;
    public float fallvelocity;

    public Camera mainCamara;
    private Vector3 mirar_adelante;
    private Vector3 mirar_derecha;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal_movimiento = Input.GetAxis("Horizontal");
        vertical_movimiento = Input.GetAxis("Vertical");

        playerinput = new Vector3(horizontal_movimiento,0,vertical_movimiento);
        playerinput = Vector3.ClampMagnitude(playerinput, 1);

        direccion_camara();

        playermovimiento = playerinput.x * mirar_derecha + playerinput.z * mirar_adelante;
        playermovimiento = playermovimiento * atributo.velocidad;
        characterController.transform.LookAt(characterController.transform.position + playermovimiento);

        gravedad();

        characterController.Move(playermovimiento * Time.deltaTime);

    }

    public void direccion_camara()
    {
        mirar_adelante = mainCamara.transform.forward;
        mirar_derecha = mainCamara.transform.right;

        mirar_adelante.y = 0;
        mirar_derecha.y = 0;

        mirar_adelante = mirar_adelante.normalized;
        mirar_derecha = mirar_derecha.normalized;
    }

    public void gravedad()
    {
        if (characterController.isGrounded)
        {
            fallvelocity = -gravity * Time.deltaTime;
            playermovimiento.y = fallvelocity;
        }
        else
        {
            fallvelocity -= gravity * Time.deltaTime;
            playermovimiento.y = fallvelocity;
        }

    }
}
