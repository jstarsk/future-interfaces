using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivideAndConquer : MonoBehaviour
{
    // PART 1 - STEP 1
    #region
    int Min = 1;
    int Max = 1000;
    int Guess = 500;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        // IMPLEMENTATION
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        // PART 2 - STEP 1
        #region
        //Input KEY ENTER UP-ARROW
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Min = Guess;
            // IMPLEMENTATION
            NextGuess();
        }

        // Input KEY ENTER UP - DOWN
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Max = Guess;
            // IMPLEMENTATION
            NextGuess();
        }
        //Input KEY ENTER ENTER
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I won!");
            // IMPLEMENTATION
            StartGame();
        }
        #endregion
    }

    // PART 1 - STEP 2
    #region
    void StartGame()
    {
        // Set the console interation with thr game user
        print("=======================================================================");
        print("Welcome to divide and conquer game");
        print("Pick a new number in your mind. Let see how good you are hiding numbers");
        print("The highest number you can pick is: " + Max);
        print("The lower number you can pick is: " + Min);
        print("Is the number > or < that " + Guess);
        print("Up arrow = >, Down arrow = <, Enter = equal");
    }
    #endregion

    // PART 2 - STEP 2
    #region
    void NextGuess()
    {
        Guess = (Max + Min) / 2;
        print("higher > or < lower than: " + Guess);
    }
    #endregion
}
