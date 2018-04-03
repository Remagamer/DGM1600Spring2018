using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LongCalculator : MonoBehaviour
{
    public InputField Input1;
    public InputField Input2;
    public Text SolutionText;


    public void RunCalculation(string _operator)
    {
        switch (_operator)
        {
            case "+":
                SolutionText.text = Add(Input1.text, Input2.text);
                break;
            case "-":
                SolutionText.text = Subtract(Input1.text, Input2.text);
                break;
            case "*":
                SolutionText.text = Multiply(Input1.text, Input2.text);
                break;
            case "/":
                SolutionText.text = Divide(Input1.text, Input2.text);
                break;
        }
    }

    private float aNum;
    private float bNum;

    public string Add(string a, string b)
    {
        aNum = float.Parse(a);
        bNum = float.Parse(b);
        return (aNum + bNum).ToString();
    }

    public string Subtract(string a, string b)
    {
        aNum = float.Parse(a);
        bNum = float.Parse(b);
        return (aNum - bNum).ToString();
    }

    public string Multiply(string a, string b)
    {
        aNum = float.Parse(a);
        bNum = float.Parse(b);
        return (aNum * bNum).ToString();
    }

    public string Divide(string a, string b)
    {
        aNum = float.Parse(a);
        bNum = float.Parse(b);
        return (aNum / bNum).ToString();
    }
}