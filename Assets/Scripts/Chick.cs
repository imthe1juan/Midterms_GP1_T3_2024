using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chick : MonoBehaviour
{
    public Hen henPrefab;
    public Rooster roosterPrefab;

    [SerializeField] private float growTime = 10;
    private bool forcedHen = false;

    private void Start()
    {
        ChickenCounter.Instance.IncreaseChickCount();
        Invoke(nameof(Grow), growTime);
    }

    // Transform the chick to either a hen or a rooster
    private void Grow()
    {
        int randomNum = Random.Range(0, 2);
        Vector3 offset = new Vector3(0.0f, 1.0f, 0.0f);

        if (forcedHen) { randomNum = 0; }
        if (randomNum == 0)
        {
            Instantiate(henPrefab, transform.position += offset, Quaternion.identity);
        }
        else
        {
            Instantiate(roosterPrefab, transform.position += offset, Quaternion.identity);
        }
        ChickenCounter.Instance.DecreaseChickCount();

        Destroy(gameObject);
    }

    //This makes sure that the first egg will be a hen
    public void ForceHen()
    {
        forcedHen = true;
    }
}