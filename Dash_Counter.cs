using UnityEngine;
using TMPro;

public class Dash_Counter : MonoBehaviour
{
    public TMP_Text Dash_Count; // Reference to the UI text (Use Text if not using TMP)
    public float Dash_Value = 0; // Initial counter value
    public float increaseRate = 1f; // How much to increase per second
    public float minValue = 0f; // Lower limit
    public float maxValue = 12f; // Upper limit

    // Update is called once per frame
    void Update()
    {
        // Increase counter value over time
        Dash_Value += increaseRate * Time.deltaTime;

        // Clamp to stay within limits
        Dash_Value = Mathf.Clamp(Dash_Value, minValue, maxValue);

        // Update the UI text
        Dash_Count.text = "Dash Count: " + Mathf.Round(Dash_Value); // Use Mathf.Round for whole numbers

        if (Input.GetKeyDown(KeyCode.E) && Dash_Value >= 4) 
        {
            Dash_Value -= 4;
        }

    }

    public void Dashed(float amount) 
    {
        Dash_Value -= 4f;
        Dash_Value = Mathf.Clamp(Dash_Value, minValue, maxValue);
    }





}
