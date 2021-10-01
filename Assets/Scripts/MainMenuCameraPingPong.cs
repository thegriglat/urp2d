using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuCameraPingPong : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1.0f;
    public float left;
    public float right;
    private int sign = 1;
    private Vector3 _startPos;
    void Start()
    {
        if (right < left)
            sign = -1;
        _startPos = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float shift = left + sign * Mathf.PingPong(Time.time * speed, Mathf.Abs(right - left));
        transform.position = _startPos + Vector3.up * shift;
    }
}
