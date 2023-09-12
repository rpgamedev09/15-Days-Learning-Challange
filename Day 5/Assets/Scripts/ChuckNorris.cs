using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChuckNoris : MonoBehaviour
{
    [SerializeField] private Text jokeText;

    public void NewJoke()
    {
        //set the text to value returned
        Joke joke = ApiHelper.GetNewJoke(); 
        jokeText.text = joke.value.ToString();
    }
}
