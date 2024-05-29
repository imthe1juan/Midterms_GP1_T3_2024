using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    public Chick chickPrefab;
    [SerializeField] private float hatchTime = 10;
    [SerializeField] private bool isForcedHen = false;

    private void Start()
    {
        ChickenCounter.Instance.IncreaseEggCount();
        Invoke(nameof(Hatch), hatchTime);
    }

    //Hatch the Egg into a chick
    private void Hatch()
    {
        Vector3 offset = new Vector3(0.0f, 1.0f, 0.0f);
        Chick chickClone = Instantiate(chickPrefab, transform.position += offset, Quaternion.identity);
        if (isForcedHen)
        {
            chickClone.ForceHen();
        }
        ChickenCounter.Instance.DecreaseEggCount();
        Destroy(gameObject);
    }
}