using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hen : MonoBehaviour, IPerishable
{
    public Transform spawnPoint;
    public GameObject egg;
    [SerializeField] private float layTime = 10;
    [SerializeField] private float deathTime = 10;

    private void Start()
    {
        ChickenCounter.Instance.IncreaseHenCount();
        Invoke(nameof(LayEggs), layTime);
        Invoke(nameof(Death), deathTime);
    }

    private void LayEggs()
    {
        int randomNum = Random.Range(2, 11); // The random will be 2 - 10
        for (int i = 0; i < randomNum; i++)
        {
            Instantiate(egg, spawnPoint.position, Quaternion.identity);
        }
    }

    public void Death()
    {
        ChickenCounter.Instance.DecreaseHenCount();
        Destroy(gameObject);
    }
}