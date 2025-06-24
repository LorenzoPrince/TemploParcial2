using UnityEngine;

public abstract class TempleObject : MonoBehaviour, IInteractable
{
    public abstract void Interact(); // obliga a que las clases hijas implementen la interacción

}
