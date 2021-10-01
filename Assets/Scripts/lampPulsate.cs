using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class lampPulsate : MonoBehaviour
{
    public float minIntensity = 0.5f;

    public float maxIntensity = 1.0f;

    public float speed = 1.0f;

    private Light2D l;
    private int sign = 1;

    // Start is called before the first frame update
    void Start()
    {
        l = GetComponent<Light2D>();
        if (maxIntensity < minIntensity) sign = -1;
    }

    // Update is called once per frame
    void Update()
    {
        l.intensity =
            minIntensity + sign * 
            Mathf.PingPong(Time.time * speed, Mathf.Abs(maxIntensity - minIntensity));
    }
}
