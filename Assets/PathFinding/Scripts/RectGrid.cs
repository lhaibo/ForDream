using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 矩形网格单元
/// </summary>
public class RectGrid : MonoBehaviour
{
    public float width=2.0f;
    public float height=2.0f;

    private Vector3[] corners;
    private void Awake()
    {
        transform.localScale = new Vector3(width, height, 1.0f);
    }

    private void OnMouseDown()
    {
        Debug.Log($"rectGrid:{transform.position}");
    }
}
