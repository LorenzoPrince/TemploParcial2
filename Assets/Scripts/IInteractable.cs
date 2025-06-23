using UnityEngine;

public interface IInteractable //Una interfaz define un contrato que otras clases deben implementar.
{
    void Interact(); // obliga que los que hagan referencias a IInteractable tengan que tener el metodo Interact
}
