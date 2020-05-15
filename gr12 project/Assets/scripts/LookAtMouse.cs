using UnityEngine;
using System.Collections;

public class LookAtMouse : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform PlayerBody;
    float xRotation = 0f;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        FaceMouse();

    }
    void FaceMouse()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        //float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

       //xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        PlayerBody.Rotate(Vector3.up * mouseX);
    }
}