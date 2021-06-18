using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndEpisode : MonoBehaviour
{
    public GameObject[] checkButtons, numbers;
    public GameObject tryAgain;
    bool endActive = false;

    public void CorrectButton()
    {
        if (SceneManager.GetActiveScene().name == "Episode1")
        {
            if (ManagerNumber.instance.correctNumber1)
            {
                Correct();
            }
            else
            {
                numbers[0].SetActive(false);
                tryAgain.SetActive(true);
                Invoke("AgainDeactive", 2f);
            }
        }

        if (SceneManager.GetActiveScene().name == "Episode2")
        {
            if (SecondManager.instance.correctNumber2 && ThirdManager.instance.correctNumber3)
            {
                Correct();
            }
            else
            {
                numbers[0].SetActive(false);
                numbers[1].SetActive(false);
                tryAgain.SetActive(true);
                Invoke("AgainDeactive", 2f);
            }
        }

        if (SceneManager.GetActiveScene().name == "Episode3")
        {
            if (ManagerNumber.instance.correctNumber1 && SecondManager.instance.correctNumber2
                && ThirdManager.instance.correctNumber3)
            {
                Correct();
            }
            else
            {
                numbers[0].SetActive(false);
                numbers[1].SetActive(false);
                numbers[2].SetActive(false);
                tryAgain.SetActive(true);
                Invoke("AgainDeactive", 2f);
            }
        }

        if (SceneManager.GetActiveScene().name == "Episode4")
        {
            if (ManagerNumber.instance.correctNumber1 && SecondManager.instance.correctNumber2
                && ThirdManager.instance.correctNumber3 && FourthManager.instance.correctNumber4)
            {
                Correct();
            }
            else
            {
                numbers[0].SetActive(false);
                numbers[1].SetActive(false);
                numbers[2].SetActive(false);
                numbers[3].SetActive(false);
                tryAgain.SetActive(true);
                Invoke("AgainDeactive", 2f);
            }
        }

        if (SceneManager.GetActiveScene().name == "Episode5")
        {
            if (ManagerNumber.instance.correctNumber1 && SecondManager.instance.correctNumber2
                && ThirdManager.instance.correctNumber3 && FourthManager.instance.correctNumber4)
            {
                Correct();
            }
            else
            {
                numbers[0].SetActive(false);
                numbers[1].SetActive(false);
                numbers[2].SetActive(false);
                numbers[3].SetActive(false);
                tryAgain.SetActive(true);
                Invoke("AgainDeactive", 2f);
            }
        }

        if (SceneManager.GetActiveScene().name == "Episode6")
        {
            if (ManagerNumber.instance.correctNumber1 && SecondManager.instance.correctNumber2
                && ThirdManager.instance.correctNumber3 && FourthManager.instance.correctNumber4)
            {
                Correct();
            }
            else
            {
                numbers[0].SetActive(false);
                numbers[1].SetActive(false);
                numbers[2].SetActive(false);
                numbers[3].SetActive(false);
                tryAgain.SetActive(true);
                Invoke("AgainDeactive", 2f);
            }
        }

        if (SceneManager.GetActiveScene().name == "Episode7")
        {
            if (ManagerNumber.instance.correctNumber1 && SecondManager.instance.correctNumber2
                && ThirdManager.instance.correctNumber3 && FourthManager.instance.correctNumber4)
            {
                Correct();
            }
            else
            {
                numbers[0].SetActive(false);
                numbers[1].SetActive(false);
                numbers[2].SetActive(false);
                numbers[3].SetActive(false);
                tryAgain.SetActive(true);
                Invoke("AgainDeactive", 2f);
            }
        }

        if (SceneManager.GetActiveScene().name == "Episode8")
        {
            if (ManagerNumber.instance.correctNumber1 && SecondManager.instance.correctNumber2
                && ThirdManager.instance.correctNumber3 && FourthManager.instance.correctNumber4)
            {
                Correct();
            }
            else
            {
                numbers[0].SetActive(false);
                numbers[1].SetActive(false);
                numbers[2].SetActive(false);
                numbers[3].SetActive(false);
                tryAgain.SetActive(true);
                Invoke("AgainDeactive", 2f);
            }
        }
    }

    public void AgainDeactive()
    {
        if (SceneManager.GetActiveScene().name == "Episode1")
        {
            tryAgain.SetActive(false);
            numbers[0].SetActive(true);
        }

        if (SceneManager.GetActiveScene().name == "Episode2")
        {
            tryAgain.SetActive(false);
            numbers[0].SetActive(true);
            numbers[1].SetActive(true);
        }

        if (SceneManager.GetActiveScene().name == "Episode3")
        {
            tryAgain.SetActive(false);
            numbers[0].SetActive(true);
            numbers[1].SetActive(true);
            numbers[2].SetActive(true);
        }

        if (SceneManager.GetActiveScene().name == "Episode4")
        {
            tryAgain.SetActive(false);
            numbers[0].SetActive(true);
            numbers[1].SetActive(true);
            numbers[2].SetActive(true);
            numbers[3].SetActive(true);
        }

        if (SceneManager.GetActiveScene().name == "Episode5")
        {
            tryAgain.SetActive(false);
            numbers[0].SetActive(true);
            numbers[1].SetActive(true);
            numbers[2].SetActive(true);
            numbers[3].SetActive(true);
        }

        if (SceneManager.GetActiveScene().name == "Episode6")
        {
            tryAgain.SetActive(false);
            numbers[0].SetActive(true);
            numbers[1].SetActive(true);
            numbers[2].SetActive(true);
            numbers[3].SetActive(true);
        }

        if (SceneManager.GetActiveScene().name == "Episode7")
        {
            tryAgain.SetActive(false);
            numbers[0].SetActive(true);
            numbers[1].SetActive(true);
            numbers[2].SetActive(true);
            numbers[3].SetActive(true);
        }

        if (SceneManager.GetActiveScene().name == "Episode8")
        {
            tryAgain.SetActive(false);
            numbers[0].SetActive(true);
            numbers[1].SetActive(true);
            numbers[2].SetActive(true);
            numbers[3].SetActive(true);
        }
    }

    private void Correct()
    {
        checkButtons[0].SetActive(false);
        checkButtons[1].SetActive(true);
        endActive = true;

        if (endActive)
        {
            Invoke("NextLevel", 0.1f);
        }
    }

    public void NextLevel()
    {
        LevelLoader.instance.LoadNextLevel();
    }
}
