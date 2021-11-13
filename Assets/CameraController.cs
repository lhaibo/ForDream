using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private bool pressed = false;
    private Vector3 mouseStartPos;
    private Vector3 cameraStartPos;
    private float moveFactor = 0.02f;
    private float sizeFactor = 4.0f;
    private Camera mainCamera;

    private void Awake()
    {
        mainCamera = GetComponent<Camera>();
    }
    private void Update()
    {
        UpdatePos();
        UpdateOrthographicSize();
    }

    private void UpdatePos()
    {
        if (Input.GetMouseButtonDown(2))
        {
            pressed = true;
            mouseStartPos = Input.mousePosition;
            cameraStartPos = transform.position;
        }
        if (Input.GetMouseButtonUp(2))
        {
            pressed = false;
        }

        if (Input.GetMouseButton(2))
        {
            float x = cameraStartPos.x - (Input.mousePosition.x - mouseStartPos.x) * moveFactor;
            float y = cameraStartPos.y - (Input.mousePosition.y - mouseStartPos.y) * moveFactor;
            transform.position = new Vector3(x, y, transform.position.z);
        }
    }

    private void UpdateOrthographicSize()
    {
        float deltaZ = Input.GetAxis("Mouse ScrollWheel");
        mainCamera.orthographicSize -= deltaZ * sizeFactor;
    }
}
