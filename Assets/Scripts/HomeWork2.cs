using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*2 Отдельно от Magic Numbers (новый скрипт):
Игра просит игрока нажимать цифры (от 1 до 9), при
нажатии какой-либо цифры её значение прибавляется к
общей сумме и выводится значение этой суммы (можно в
консоль, можно создать Text). При достижении значения
суммы 50 (значение 50 вынести в переменную) игра
заканчивается и выводится сообщение об окончании
(например:
"Игра
окончена"),
также
выводится
количество затраченных ходов, игра начинается заново.
При нажатии на пробел сумма обнуляется.
Пример:
"Нажмите цифру:"
5
"Сумма: 5"
6
"Сумма: 11"
9
"Сумма: 20"
...
"Сумма: 50"
"Игра окончена! Количество ходов: 15" */
public class HomeWork2 : MonoBehaviour
{
    public Text label;
    public int sum;
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartGame();
        }
        else if (sum >= 50)
        {
            FinishGame();
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))
            {
                UpdateGame(1);
            }
            if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2))
            {
                UpdateGame(2);
            }
            if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3))
            {
                UpdateGame(3);
            }
            if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4))
            {
                UpdateGame(4);
            }
            if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5))
            {
                UpdateGame(5);
            }
            if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6))
            {
                UpdateGame(6);
            }
            if (Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7))
            {
                UpdateGame(7);
            }
            if (Input.GetKeyDown(KeyCode.Keypad8) || Input.GetKeyDown(KeyCode.Alpha8))
            {
                UpdateGame(8);
            }
            if (Input.GetKeyDown(KeyCode.Keypad9) || Input.GetKeyDown(KeyCode.Alpha9))
            {
                UpdateGame(9);
            }
        }
    }

    public void StartGame()
    {
        sum = 0;
        count = 0;
        label.text = "Нажмите цифру от 1 до 9:\n";
    }
    public void UpdateGame(int a)
    {
        sum += a;
        label.text = "Нажмите цифру от 1 до 9:\n" + a + "\nСумма: " + sum;
        count++;
    }
    public void FinishGame()
    {
        label.text = "Игра окончена! Количество ходов: " + count +
                     "\nЧтобы начать заного нажмите пробел.\n";
    }
}
