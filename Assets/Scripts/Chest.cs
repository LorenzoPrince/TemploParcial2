using UnityEngine;

public class Chest : TempleObject
{ 

    private bool isOpen = false;
   // [SerializeField] private KeyItem llaveRequerida;
    public override void Interact()
    {
        if (isOpen == false)
        {
            isOpen = true;
            Debug.Log("Habriste el cofre");
        }
        else
        {
            Debug.Log("El cofre ya fue abierto");
        }
    }
}
