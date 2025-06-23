using UnityEngine;

public class Player : Character
{
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
    //agregar mas metodos

}
