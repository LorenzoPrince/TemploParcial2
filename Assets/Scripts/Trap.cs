using UnityEngine;

public class Trap : TempleObject
{
    [SerializeField] private int da�o = 10;

    public override void Interact()
    {
        Debug.Log("Has activado una trampa!");
        Player player = Object.FindFirstObjectByType<Player>(); //nuevo metodo para buscar la clase
        if (player != null)
        {
            player.RecibirDa�o(da�o);
        }
    }
}

