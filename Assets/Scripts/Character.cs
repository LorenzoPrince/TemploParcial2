using UnityEngine;

public abstract class Character : MonoBehaviour // clase abstracta la cual no se puede instanciar directamente, si no a trav�s de clases hijas.
{
    protected int vida; //usamos protected para que solo puedan acceder las clases hijas.
    [SerializeField] protected float velocidad;
    protected bool vivo;

    protected virtual void Mover() // Mover es virtual con cuerpo vac�o para que las subclases no se mueven no tengan que implementarla
    {
        // Por defecto no se mueve
    }
    protected virtual void Morir() // virtual para personajes que no mueran quizas aldeanos.
    {

    }


    public virtual void RecibirDa�o(int cantidad)    // Recibir da�o es virtual para que otras clases puedan modificar el comportamiento si quieren
    {
        if (!vivo) return; // si no esta vivo retorna nada.

        vida -= cantidad; //descuenta da�o
        Debug.Log($"{name} recibi� {cantidad} de da�o. Vida restante: {vida}"); //verifico

        if (vida <= 0)
        {
            vivo = false; // se da por muerto.
            Morir();
        }
    }

}
