using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivideAndConquer : MonoBehaviour
{
    public int _Min =0 ;
    public int _Max = 1000;
    int Min;
    int Max;
    int Guess;


    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        // Input Key - UUpArrow
        if (Input.GetKeyDown(KeyCode.UpArrow)){
            print("Key UpArrow press");
            Min = Guess;
            NextGuess();
        }
        // Input Key - DownArrow
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Key DownArrow press");
            Max = Guess;
            NextGuess();

        }
        // Input Key - Return
        if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I won!");
            StartGame();
        }
    }



    /// <summary>
    /// //////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    void NextGuess() {
        Guess = (Max + Min) / 2;
        print("Higher number > or < lower than :" + Guess);
    }


    void StartGame()
    {
        SetupParamters();
        print("=============================================");
        print("Welcome to divide and conquer game");
        print("Pick a new number in your mind. Let see how good you are hiding numbers");
        print("The highest number you can pick is " + Max);
        print("The lower number you can pick is " + Min);
        print("is the number > or < :" + Guess);
        print("Up arrow = >, Down arrow = <, Enter = equal");
    }

    void SetupParamters()
    {
        Min = _Max;
        Max = _Min;
        Guess = 500;
    }



}
