using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ManagerNumber : MonoBehaviour
{
    [SerializeField] private Button downButton;
    [SerializeField] private Button upButton;
    public int currentNumber;

    public bool correctNumber1 = false;

    public static ManagerNumber instance;

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

        if (SceneManager.GetActiveScene().name == "Episode1")
        {
            if (currentNumber == NumberMix.instance.index)
            {
                correctNumber1 = true;
            }
        }

        if (SceneManager.GetActiveScene().name == "Episode3")
        {
            if (currentNumber == NumberMix.instance.index)
            {
                correctNumber1 = true;
            }
        }

        if (SceneManager.GetActiveScene().name == "Episode4")
        {
            if (currentNumber == NumberMix.instance.index)
            {
                correctNumber1 = true;
            }
        }

        if (SceneManager.GetActiveScene().name == "Episode5")
        {
            if (currentNumber == NumberMix.instance.index)
            {
                correctNumber1 = true;
            }
        }

        if (SceneManager.GetActiveScene().name == "Episode6")
        {
            if (currentNumber == NumberMix.instance.index)
            {
                correctNumber1 = true;
            }
        }

        if (SceneManager.GetActiveScene().name == "Episode7")
        {
            if (currentNumber == NumberMix.instance.index)
            {
                correctNumber1 = true;
            }
        }

        if (SceneManager.GetActiveScene().name == "Episode8")
        {
            if (currentNumber == NumberMix.instance.index)
            {
                correctNumber1 = true;
            }
        }
    }
}
