using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberMix : MonoBehaviour
{
    public static NumberMix instance;

    public int index;

    private void Awake()
    {
        instance = this;
    }

    public void ShowRandomSprite()
    {
        index = UnityEngine.Random.Range(1, 10);
        int childCount = transform.childCount;

        for (int i = 0; i < childCount; i++)
        {
            Transform child = transform.GetChild(i);
            bool shouldShow = index == i;

            child.gameObject.SetActive(shouldShow);
        }
    }

    private void OnEnable()
    {
        ShowRandomSprite();
    }
}
