using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float acceleration = 5f;
    public float currentSpeed = 0f;
    public float maxSpeed = 100f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Accelerate();
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            currentSpeed = Mathf.Lerp(currentSpeed, 0, 0.1f * Time.deltaTime);
        }
    }
    public void Accelerate()
    {
        if (currentSpeed < maxSpeed)
        {
            currentSpeed += acceleration * Time.deltaTime;
        }
    }
    public float GetSpeed()
    {
        return currentSpeed;
    }
}
