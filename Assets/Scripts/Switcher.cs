using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
public class Switcher : MonoBehaviour
{
    public enum JimmyExpressions
    {
        Default,
        Finals2020,
        Dreads,
        Emo
    }

    public JimmyExpressions jimmyExpressions;
    public List<GameObject> jimmyList;

    private void Update()
    {
        switch (jimmyExpressions)
        {
            case JimmyExpressions.Default:
                DisableOthers();
                jimmyList[0].SetActive(true);
                break;

            case JimmyExpressions.Finals2020:
                DisableOthers();
                jimmyList[1].SetActive(true);
                break;

            case JimmyExpressions.Dreads:
                DisableOthers();
                jimmyList[2].SetActive(true);
                break;

            case JimmyExpressions.Emo:
                DisableOthers();
                jimmyList[3].SetActive(true);
                break;

            default:
                break;
        }
    }

    private void DisableOthers()
    {
        for (int i = 0; i < jimmyList.Count; i++)
        {
            jimmyList[i].SetActive(false);
        }
    }
}