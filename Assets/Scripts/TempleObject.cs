using UnityEngine;

public abstract class TempleObject : MonoBehaviour, IInteractable
{
    public abstract void Interact(); // obliga a que las clases hijas implementen la interacci�n
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
