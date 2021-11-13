using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridTypeSettings : MonoBehaviour
{
    private GameObject item;

    private void Awake()
    {
        item = transform.GetChild(0).gameObject;
    }

    private void Start()
    {
        InitGridTypeSettings();
    }

    private void InitGridTypeSettings()
    {
        for (int i = 0; i < (int)GridType.GridTypeCount; i++)
        {
            GameObject obj = GameObject.Instantiate(item, transform);
            obj.transform.Find("Label").GetComponent<Text>().text = ((GridType)i).ToString();
            obj.SetActive(true);
        }
    }
}
