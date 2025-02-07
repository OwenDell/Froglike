using UnityEngine;
using TMPro;

public class Bubble_Counter : MonoBehaviour
{
    public TMP_Text Bubble_Count; // Reference to the UI text (Use Text if not using TMP)
    public float Bubble_Value = 0; // Initial counter value
    public float increaseRate = 3f; // How much to increase per second
    public float minValue = 0f; // Lower limit
    public float maxValue = 12f; // Upper limit

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Increase counter value over time
        Bubble_Value += increaseRate * Time.deltaTime;

        // Clamp to stay within limits
        Bubble_Value = Mathf.Clamp(Bubble_Value, minValue, maxValue);

        // Update the UI text
        Bubble_Count.text = "Bubble Count: " + Mathf.Round(Bubble_Value); // Use Mathf.Round for whole numbers

        if (Input.GetKeyDown(KeyCode.R) && Bubble_Value >= 4)
        {
            Bubble_Value -= 4;
        }

    }
}
