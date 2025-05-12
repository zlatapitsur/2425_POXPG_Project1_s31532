using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class GameController : MonoBehaviour
{
    public string mainWord = "default";
    public int livesCount = 10;
    public TextMeshProUGUI mainWordText;
    public TextMeshProUGUI livesCountText;
    public TextMeshProUGUI messageText;
    public TMP_InputField inputField;


    // Start is called before the first frame update
    void Start()
    {
        mainWordText.text = mainWord;
        livesCountText.text = $"Zostało {livesCount} prób";
    }

    public void OnClick()
    {
        Debug.Log($"Guzik został kliknięty");
        //livesCount = livesCount - 1;
        //livesCount -= 1;
        livesCount--;
        livesCountText.text = $"Zostało {livesCount} prób";

        if (mainWord == inputField.text)
        {
            messageText.text = $"Poprawne słowo zostało wpisane";
            return;  //Koniec metody
        }

        if (mainWord.Length != inputField.text.Length) 
        {
            messageText.text = $"Liczba liter sie nie zgadza";
            return;  //Koniec metody
        }


        int bullsCount = CountBulls();
        int cowsCount = CountCows();
       messageText.text = $"Bulls: {bullsCount} and Cows: {cowsCount}";

    }

    public int CountBulls()
    {

        int result = 0;

        for (int i = 0; i < mainWord.Length; i++)
        {
            if(mainWord[i] == inputField.text[i])
            {

                result++;
            }

        }

        return result;
    }

    public int CountCows()
    {
        int result = 0;

        for (int i = 0; i < mainWord.Length; i++)
        {
            if (mainWord[i] != inputField.text[i] && mainWord.Contains(inputField.text[i]) )
            {

                result++;
            }

        }

        return result;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
