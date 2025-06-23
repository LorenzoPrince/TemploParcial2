using UnityEngine;

public class Villager : TempleObject
{
    [SerializeField] private string villagerName = "Aldeano";

    public override void Interact()
    {
        Debug.Log($"{villagerName} dice: ¡Hola!");

    }

    public void CurarJugador(Player player)
    {
       // player.RecibirCura(20);  // Método que puedes implementar en Player
        Debug.Log($"{villagerName} te ha curado.");
    }
}
