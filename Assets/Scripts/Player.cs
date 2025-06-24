using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class Player : Character
{
    private IInteractable currentInteractable; //guardamos con el q interactuamos
    void Awake()
    {
        vida = 100;
        velocidad = 5f;
        vivo = true;

    }

    void Update()
    {
        if (vivo)
        {
            Mover();

            if (currentInteractable != null && Input.GetKeyDown(KeyCode.E)) //si hay objecto interactuable cerca y se presiona E
            {
                currentInteractable.Interact();
            }
        }
    }

    protected override void Mover() // Utilizo override para sobrescribir el virtual del Character.
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(x, y, 0).normalized; //Normalizamops para no ir mas rapido en dialgonal


        transform.position += dir * velocidad * Time.deltaTime; // Movemos el personaje en el mundo 2D
    }
    protected override void Morir()
    {
        vivo = false;
        Debug.Log("El jugador ha muerto.");
        // Logica de Game Over o animaciones
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        IInteractable interactable = collision.GetComponent<IInteractable>(); //verificamos si el objecto que entro tiene un componente IInteractable
        if (interactable != null)
        {
            currentInteractable = interactable; //lo guardamos
            Debug.Log("Objeto interactuable cerca: " + collision.name);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<IInteractable>() == currentInteractable) //vemos si el triger que salio es el mismo con el que estábamso interactuando
        {
            currentInteractable = null; //deja de ser interacrtuable actualmente
            Debug.Log("Objeto interactuable fuera de alcance");
        }
    }

}
