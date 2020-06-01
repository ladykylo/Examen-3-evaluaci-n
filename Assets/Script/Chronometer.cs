using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chronometer : MonoBehaviour
{
    public Text time;
    float chronometer;

    void Start()
    {
        time.text = "tiempo";
    }

    // Update is called once per frame
    void Update()
    {
        chronometer += Time.deltaTime;
        time.text = "" + Mathf.Floor(chronometer);
    }
}
