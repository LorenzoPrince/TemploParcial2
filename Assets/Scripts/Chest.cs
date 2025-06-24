using UnityEngine;

public class Chest : TempleObject
{ 

    private bool isOpen = false; // la variable privada que bno se puede acceder.
    public bool IsOpen //buena practica que la primera letra se mayuscula del que asigna el get y set
    {
        get { return isOpen; } // retorna el valor osea te lo muestra cuando lo pidas
        private set //esto va hacer que solo se puede cambiar adentro de la clase.
        {
            if (value != isOpen) //condicional para verificar si es distinto al de ahora.
            {
                isOpen = value; // asigna el nuevo valor osea el value
                Debug.Log("Ya se abrio cofre");
            }
        }
    }

    public override void Interact()
    {
        if (isOpen == false)
        {
            isOpen = true; //Aca le habla al setter para que cambie por true
            Debug.Log("Habriste el cofre");
        }
        else
        {
            Debug.Log("El cofre ya fue abierto");
        }
    }
}
