using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ThirdManager : MonoBehaviour
{
    [SerializeField] private Button downButton;
    [SerializeField] private Button upButton;
    public int currentNumber;

    public static ThirdManager instance;

    public bool correctNumber3 = false;

    private void Awake()
    {
        instance = this;
        SelectNumber(0);
    }

    private void SelectNumber(int _index)
    {
        downButton.interactable = (_index != 0);
        upButton.interactable = (_index != transform.childCount - 1);

        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == _index);
        }
    }

    public void ChangeNumber(int _change)
    {
        currentNumber += _change;
        SelectNumber(currentNumber);

        if (SceneManager.GetActiveScene().name == "Episode2")
        {
            if (currentNumber == SecondMix.instance.index)
            {
                correctNumber3 = true;
            }
        }

        if (SceneManager.GetActiveScene().name == "Episode3")
        {
            if (currentNumber == ThirdMix.instance.index)
            {
                correctNumber3 = true;
            }
        }

        if (SceneManager.GetActiveScene().name == "Episode4")
        {
            if (currentNumber == ThirdMix.instance.index)
            {
                correctNumber3 = true;
            }
        }

        if (SceneManager.GetActiveScene().name == "Episode5")
        {
            if (currentNumber == ThirdMix.instance.index)
            {
                correctNumber3 = true;
            }
        }

        if (SceneManager.GetActiveScene().name == "Episode6")
        {
            if (currentNumber == ThirdMix.instance.index)
            {
                correctNumber3 = true;
            }
        }

        if (SceneManager.GetActiveScene().name == "Episode7")
        {
            if (currentNumber == ThirdMix.instance.index)
            {
                correctNumber3 = true;
            }
        }

        if (SceneManager.GetActiveScene().name == "Episode8")
        {
            if (currentNumber == ThirdMix.instance.index)
            {
                correctNumber3 = true;
            }
        }
    }
}
