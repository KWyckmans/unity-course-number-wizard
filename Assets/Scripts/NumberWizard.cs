using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;

    [SerializeField] TextMeshProUGUI guessText;

    int guess;

    List<int> guesses = new List<int>();

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        if(this.min >= this.max){
            Debug.LogError("Min value is larger than max value");
        }

        this.NextGuess();
    }

    public void OnPressHigher()
    {
        this.min = this.guess + 1;
        Debug.Log("Need to guess higher, new max is " + this.min.ToString());

        NextGuess();
    }

    public void OnPressLower()
    {
        this.max = this.guess - 1;
        Debug.Log("Need to guess lower, new max is " + this.max.ToString());
        NextGuess();
    }

    void NextGuess()
    {
        this.guess = Random.Range(this.min, this.max + 1);
        guessText.SetText(guess.ToString());
    }
}
