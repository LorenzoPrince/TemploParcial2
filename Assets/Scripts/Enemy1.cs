using UnityEngine;

public class Enemy1 : Character
{

    public Transform objetivo;  // El jugador
    private Rigidbody2D rb;
    private void Awake()
    {
        vida = 50;
        velocidad = 3f;
        vivo = true;

        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (vivo)
        {
            Mover();
        }
    }

    protected override void Mover()
    {
        if (objetivo != null)
        {
            Vector2 direccion = (objetivo.position - transform.position).normalized;
            rb.linearVelocity = direccion * velocidad;

            Debug.Log("El enemigo se mueve hacia el objetivo.");
        }
    }

    protected override void Morir()
    {
        vivo = false;
        rb.linearVelocity = Vector2.zero; // Detiene el movimiento al morir
        Debug.Log("El enemigo ha muerto.");
        //      Destroy(gameObject, 1.5f);
        // Agregar animaciones o etc
    }
}
