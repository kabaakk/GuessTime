using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;

    public static float FocusPoint = 100;

    public GameObject canvas;

    public static LevelLoader instance;

    private void Start()
    {
        canvas.SetActive(false);
        Invoke("ActiveCanvas", 0.7f);
    }

    public void ActiveCanvas()
    {
        canvas.SetActive(true);
    }

    private void Awake()
    {
        instance = this;
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }

    public void RestartLevel()
    {
        if (FocusPoint > 0)
        {
            FocusPoint -= 0.05f;
        } else
        {
            FocusPoint = 0;
        }
        
        StartCoroutine(LoadLevel(1));
    }
}
