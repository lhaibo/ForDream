using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GridType
{
    None,
    Start,
    Goal,
    Road,
    Mountain,
    Water,
    Tree,
    GridTypeCount
}

public class GameData:SingletonBase<GameData>
{
    private int mapWidth;
    private int mapHeight;

    public int MapWidth { get => mapWidth; set => mapWidth = value; }
    public int MapHeight { get => mapHeight; set => mapHeight = value; }
}

public class GridMap : MonoBehaviour
{
    [SerializeField]private RectGrid grid;

    [SerializeField] private int mapWidth;
    [SerializeField] private int mapHeight;

    private GridType[,] map;

    private void Awake()
    {
        mapWidth = GameData.Instance.MapWidth;
        mapHeight = GameData.Instance.MapHeight;
        map = new GridType[mapWidth,mapHeight];   
    }

    private void Start()
    {
        InitMap();
    }


    private void InitMap()
    {
        for (int i = 0; i < mapWidth; i++)
        {
            for (int j = 0; j < mapHeight; j++)
            {
                map[i, j] = GridType.None;
                GameObject obj = GameObject.Instantiate(grid.gameObject, transform);
                obj.transform.position = new Vector3(grid.width * i, grid.width * j, grid.gameObject.transform.position.z);
                obj.SetActive(true);
            }
        }
    }
}
