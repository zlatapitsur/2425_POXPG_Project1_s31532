using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class GameController : MonoBehaviour
{
    public string mainWord = "default";
    public TextMeshProUGUI mainWordText;
    // Start is called before the first frame update
    void Start()
    {
        mainWordText.text = mainWord;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
