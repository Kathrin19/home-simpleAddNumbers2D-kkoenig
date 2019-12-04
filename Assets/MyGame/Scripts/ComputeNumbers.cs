using UnityEngine;
using UnityEngine.UI;

public class ComputeNumbers : MonoBehaviour
{
    public InputField ip_varA;
    public InputField ip_varB;
    public Text result;
    public Button Btn_Add;
    public Button Btn_Reset;


    public void SetResult()
    {
        float a = float.Parse(ip_varA.text);
        float b = float.Parse(ip_varB.text);
        result.text = AddNumbers(a, b).ToString();
        ip_varA.interactable = false;
        ip_varB.interactable = false;
        Btn_Add.interactable = false;
        Btn_Reset.interactable = true;
    }

    public void Reset()
    {
        ip_varA.text = "0";
        ip_varB.text = "0";
        result.text = "0";
        ip_varA.interactable = true;
        ip_varB.interactable = true;
        Btn_Add.interactable = true;
        Btn_Reset.interactable = false;
    }

    private float AddNumbers(float variableA, float variableB)
    {
        float result = variableA + variableB;
        return result;
    }
}
