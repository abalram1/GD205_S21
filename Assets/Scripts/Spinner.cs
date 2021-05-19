using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spinner : MonoBehaviour
{
    public int Minimum_Value;
    public int Maximum_Value;
    public TextMeshProUGUI Spinner_Output_Display;

    // Start is called before the first frame update
    public int Spin_Spinner()
    {
        int Value;
        Value = (int) Random.Range(Minimum_Value, Maximum_Value+1);
        Spinner_Output_Display.text = Value.ToString();
        Debug.LogError(Value);
        return Value;
    }
}
