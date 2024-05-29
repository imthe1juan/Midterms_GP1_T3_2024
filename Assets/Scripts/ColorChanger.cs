using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    public Color[] colors;
    public Image image;
    private int chosenColor;
    public bool automatic = false;
    private float delay;

    private void Update()
    {
        if (!automatic) return;
        delay -= Time.deltaTime;
        if (delay <= 0)
        {
            delay = .5f;
            ChangeColor();
        }
    }

    public void ChangeColor()
    {
        chosenColor++;
        if (chosenColor >= colors.Length)
        {
            chosenColor = 0;
        }
        image.color = colors[chosenColor];
    }

    public void ToggleAutomatic()
    {
        automatic = !automatic;
    }
}