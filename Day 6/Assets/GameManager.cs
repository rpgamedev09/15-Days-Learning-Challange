using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour {

    //Learning Collections....
    //Array
    //list 
    //IEnumerables
    //Dictonaries
    private void Start()
    {
        // Array 
        string[] Anime = new string[5];
        
        Anime[0] = "Attack On Titan";
        Anime[1] = "Naruto";
        Anime[2] = "Deamon Slayers";
        Anime[3] = "Jujutsu Kaisen";
        Anime[4] = "OverFlow :)";

        PrintValue(Anime);

        // List
        List<string>  nameOfCharacters = new List<string>();

        nameOfCharacters.Add("Eran Yeger");
        nameOfCharacters.Add("Usumaki Naruto");
        nameOfCharacters.Add("Tanjiro Kamado");
        nameOfCharacters.Add("Satoru GoJo");
        nameOfCharacters.Add("Kazushi Sudou");

        PrintValue(nameOfCharacters);

        // Ienumarable 
        IEnumerable<string> sideCharacters = NameOfSideCharacters();
        List<string> names = sideCharacters.ToList();
        PrintValue(names);
        //really performent way 

        //Dictonaries
        Dictionary<string,Character> characters = new Dictionary<string,Character>();
        characters["Eren"] = new Character("Eran Yeager",100);
        characters["Naruto"] = new Character("Usumaki Naruto", 100);
        characters["Tanjiro"] = new Character("Tanjiro Kamado", 100);
        characters["Eren"] = new Character("Satoru GoJo", 100);
        characters["Eren"] = new Character("Kazushi Sudou", 1000000);

    }

    IEnumerable<string> NameOfSideCharacters()
    {
        yield return "Mikasa";
        yield return "Sasuke";
        yield return "Mitsuri";
        yield return "Itadori";
        yield return "Shirakawa";

    }

    public void PrintValue(IEnumerable objects)
    {
        foreach (var obj in objects)
        {
            Debug.Log(obj);  
        }
    }
}
