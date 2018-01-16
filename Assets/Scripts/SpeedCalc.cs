using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedCalc : MonoBehaviour {

    public Text txtRefSpeed;
    private Rigidbody rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        float Speed = rb.velocity.magnitude;
        if (Speed < 0)
            Speed = 0;
        int spd = Mathf.RoundToInt(Speed*3);
        txtRefSpeed.text = spd.ToString();
    }
}
