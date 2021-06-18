using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCalculations : MonoBehaviour
{
    public Text pointText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        pointText.text = LevelLoader.FocusPoint.ToString();
    }
}
