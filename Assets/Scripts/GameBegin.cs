using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameBegin : MonoBehaviour
{
    public void Begin()
    {
        SceneManager.LoadScene("Episode1");
    }
}
