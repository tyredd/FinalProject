using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderControl : MonoBehaviour
{
    
    public Transform finishLine; // Assign the object you want to track
    public Slider distanceSlider;   // Assign the UI slider

    private Vector3 startPosition;

    void Start()
    {
        // Store the starting position of the object
        startPosition = finishLine.position;
        Debug.Log("Finish position" + startPosition);
    }

    void Update()
    {
        // Calculate the distance from the start position
        float distance = Vector3.Distance(startPosition, finishLine.position);

        // Update the slider
        UpdateDistanceSlider(distance);
    }

    void UpdateDistanceSlider(float distance)
    {
        // Assuming the slider's max value is set to the maximum distance you expect
        distanceSlider.value = distance;
    }
}
