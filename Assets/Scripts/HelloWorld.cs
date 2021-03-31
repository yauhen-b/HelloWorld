using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;

//Magic Numbers script
public class HelloWorld : MonoBehaviour
{
    public Text label;
    public int min;
    public int max;
    public int count;
    public int guess;
    
    // Start is called before the first frame update
    private void Start()
    {
        StartGuess();
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            UpdateGuess();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            UpdateGuess();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartGuess();
        }
        if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {
            label.text = "Конец";
        }
    }

    private void UpdateGuess()
    {
        guess = (min + max) / 2;
        label.text = "Твоё число равно " + guess + "?\n число попыток равно " + ++count;
    }

    private void StartGuess()
    {
        min = 1;
        max = 1000;
        guess = (min + max) / 2;
        count = 0;
        label.text = "Загадай число от " + min + " до " + max + 
                     "\n Твоё число равно " + guess + "?\n число попыток равно " + ++count;
    }
}
