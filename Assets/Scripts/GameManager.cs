using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject trapPrefab; //usamos Serializa para que sea privado el atributo pero que se pueda acceder desde el inspector
    [SerializeField] private GameObject chestPrefab;
    [SerializeField] private GameObject villagerPrefab;
    void Start()
    {

        //instanciamos las cosas al iniciar.
        Instantiate(chestPrefab, new Vector3(0f, 0f, 0f), Quaternion.identity);
        Instantiate(trapPrefab, new Vector3(2f, 0f, 0f), Quaternion.identity);
        Instantiate(villagerPrefab, new Vector3(-2f, 0f, 0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
