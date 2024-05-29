using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rooster : MonoBehaviour, IPerishable
{
    [SerializeField] private float deathTime = 10;

    private void Start()
    {
        ChickenCounter.Instance.IncreaseRoosterCount();

        Invoke(nameof(Death), deathTime);
    }

    public void Death()
    {
        ChickenCounter.Instance.DecreaseRoosterCount();
        Destroy(gameObject);
    }
}