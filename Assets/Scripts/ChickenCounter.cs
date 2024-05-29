using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChickenCounter : MonoBehaviour
{
    public static ChickenCounter Instance;
    [SerializeField] private TextMeshProUGUI eggCountText;
    [SerializeField] private TextMeshProUGUI chickCountText;
    [SerializeField] private TextMeshProUGUI henCountText;
    [SerializeField] private TextMeshProUGUI roosterCountText;

    [SerializeField] private int eggCount;
    [SerializeField] private int chickCount;
    [SerializeField] private int henCount;
    [SerializeField] private int roosterCount;

    private void Awake()
    {
        Instance = this;
    }

    public void IncreaseEggCount()
    {
        eggCount++;
        eggCountText.text = eggCount.ToString();
    }

    public void DecreaseEggCount()
    {
        eggCount--;
        eggCountText.text = eggCount.ToString();
    }

    public void IncreaseChickCount()
    {
        chickCount++;
        chickCountText.text = chickCount.ToString();
    }

    public void DecreaseChickCount()
    {
        chickCount--;
        chickCountText.text = chickCount.ToString();
    }

    public void IncreaseHenCount()
    {
        henCount++;
        henCountText.text = henCount.ToString();
    }

    public void DecreaseHenCount()
    {
        henCount--;
        henCountText.text = henCount.ToString();
    }

    public void IncreaseRoosterCount()
    {
        roosterCount++;
        roosterCountText.text = roosterCount.ToString();
    }

    public void DecreaseRoosterCount()
    {
        roosterCount--;
        roosterCountText.text = roosterCount.ToString();
    }
}