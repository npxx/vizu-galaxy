using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera cam;
    public Transform target;
    public float zoomSpeed = 10.0f;
    // [SerializeField] private Vector3 initialPosition;

    private Vector3 prevPosition;

    private void Start()
    {
        // cam.transform.position = target.position;
        // cam.transform.Translate(new Vector3(0, 0, -10));
        // cam.fieldOfView = 45f;
    }

    private void Update()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        Debug.Log(scroll);
        if(scroll != 0f)
            cam.fieldOfView = Mathf.Clamp(cam.fieldOfView - (scroll * zoomSpeed), 40f, 80f);

        if (Input.GetMouseButtonDown(0))
        {
            prevPosition = cam.ScreenToViewportPoint(Input.mousePosition);
            Debug.Log("click!");
        }

        if(Input.GetMouseButton(0))
        {
            Vector3 direction = prevPosition - cam.ScreenToViewportPoint(Input.mousePosition);

            cam.transform.position = target.position;

            cam.transform.Rotate(new Vector3(1, 0, 0), direction.y * 180);
            cam.transform.Rotate(new Vector3(0, 1, 0), -direction.x * 180, Space.World);
            cam.transform.rotation = Quaternion.Euler(Mathf.Clamp(cam.transform.localRotation.eulerAngles.x, 5f, 90f), cam.transform.eulerAngles.y, cam.transform.eulerAngles.z);
            if(cam.transform.up.y < 0)
                cam.transform.rotation = Quaternion.Euler(90f, cam.transform.eulerAngles.y, cam.transform.eulerAngles.z);
            cam.transform.Translate(new Vector3(0, 0, -10));

            prevPosition = cam.ScreenToViewportPoint(Input.mousePosition);
        }  

        if(Input.GetKey(KeyCode.W))
        {
            cam.transform.position += new Vector3(0, 0, 0.5f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            cam.transform.position += new Vector3(-0.5f, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            cam.transform.position += new Vector3(0, 0, -0.5f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            cam.transform.position += new Vector3(0.5f, 0, 0);
        }
    }
}

