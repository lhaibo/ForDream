using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapSettings : MonoBehaviour
{
    private InputField width;
    private InputField height;
    private Button creatMapBtn;

    private void Awake()
    {
        width = transform.Find("InputWidth/InputField").GetComponent<InputField>();
        height = transform.Find("InputHeight/InputField").GetComponent<InputField>();
        creatMapBtn = transform.Find("CreatMapBtn").GetComponent<Button>();
    }

    private void Start()
    {
        creatMapBtn.onClick.AddListener(OnClickCreatMapBtn);
    }

    public void OnClickCreatMapBtn()
    {
        GameData.Instance.MapWidth = int.Parse(width.text);
        GameData.Instance.MapHeight = int.Parse(height.text);
        gameObject.SetActive(false);
        //暂时使用Resources加载，TODO: 使用AssetBundle加载资源
        InitGridMap();
        InitGridTypeSettings();
    }

    public void InitGridMap()
    {
        GameObject buffer = ResourcesMgr.Instance.Load<GameObject>("Prefabs/AStar/GridMap");
        GameObject.Instantiate(buffer);
    }

    public void InitGridTypeSettings()
    {
        GameObject buffer = ResourcesMgr.Instance.Load<GameObject>("Prefabs/AStar/GridTypeSettings");
        GameObject obj = GameObject.Instantiate(buffer,transform.parent);
        obj.SetActive(true);
    }
}
