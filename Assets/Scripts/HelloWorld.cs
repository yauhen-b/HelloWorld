using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public int min = 1;
    [SerializeField]
    private int max = 1000;
    
    private int guess;
    
    // Start is called before the first frame update
    private void Start()
    {
        print(message:"Загадай число от " + min +" до " + max);
        UpdateGuess();
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
        if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {
            print(message:"Конец");
        }
    }

    private void UpdateGuess()
    {
        guess = (min + max) / 2;
        print(message:"Твоё число равно " + guess + "?");
    }
}
