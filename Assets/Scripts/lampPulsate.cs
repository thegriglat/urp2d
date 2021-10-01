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

    // Start is called before the first frame update
    void Start()
    {
        l = GetComponent<Light2D>();
    }

    // Update is called once per frame
    void Update()
    {
        l.intensity =
            minIntensity +
            Mathf.PingPong(Time.time * speed, maxIntensity - minIntensity);
    }
}
