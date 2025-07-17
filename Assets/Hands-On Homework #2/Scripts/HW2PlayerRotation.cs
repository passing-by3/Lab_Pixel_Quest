using UnityEngine;

public class HW2PlayerRotation : MonoBehaviour
{
    private Camera c;

    private string CameraName = "Game_Camera";

    private Vector3 _positionMouse;

    private void Start()
    {
        c = GameObject.Find(CameraName).GetComponent<Camera>();
    }

    private void Update()
    {
        _positionMouse = c.ScreenToWorldPoint(Input.mousePosition);

        Vector3 pos = _positionMouse - transform.position;

        float rotZ = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, rotZ - 90);
    }
}
