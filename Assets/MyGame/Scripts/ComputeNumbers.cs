using UnityEngine;
using UnityEngine.UI;

public class ComputeNumbers : MonoBehaviour
{
    public InputField ip_varA;
    public InputField ip_varB;
    public Text result;

    public void SetResult()
    {
        float a = float.Parse(ip_varA.text);
        float b = float.Parse(ip_varB.text);
        result.text = AddNumbers(a, b).ToString();
    }

    private float AddNumbers(float variableA, float variableB)
    {
        float result = variableA + variableB;
        return result;
    }
}
