using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CarManager : MonoBehaviour
{
    public CarController Car1;
    public CarController Car2;

    public Text car1SpeedText;
    public Text car2SpeedText;
    public Text speedDifferenceText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        car1SpeedText.text = "Car 1 Speed: " + Car1.GetSpeed().ToString("F2") + " km/h";
        car2SpeedText.text = "Car 2 Speed: " + Car2.GetSpeed().ToString("F2") + " km/h";

        float speedDifference = Mathf.Abs(Car1.GetSpeed() - Car2.GetSpeed());
        speedDifferenceText.text = "Speed Difference: " + speedDifference.ToString("F2") + " km/h";
    }
}
