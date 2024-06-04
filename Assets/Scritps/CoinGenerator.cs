using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    public GameObject coinReference;
    public Transform player;
    public int numberOfCoinsToCreate = 10;

    // Start is called before the first frame update
    void Start()
    {
        CreateCoinsAutomatically();
    }

    void CreateCoinsAutomatically()
    {
        for(int i = 0; i < numberOfCoinsToCreate; i++)
        {
            Instantiate(coinReference, new Vector3(player.position.x, player.position.y, player.position.z), Quaternion.identity);
        }
    }

}
