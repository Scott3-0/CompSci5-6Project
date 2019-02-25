using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TomConvo1 : MonoBehaviour {
    public Text TomText;
    public Text PlayerText1;
    public Text PlayerText2;
    public GameObject Choice1;
    public GameObject Choice2;
    public GameObject ContinueButton;
    public Button Button1;
    public Button Button2;
    public Button ContButton;
    int Option;
    int choice;
    int cont;
    bool rememberedName;
    string playerName = "Jackie";

    void Start() {
        Debug.Log("Start");
        Option = 0;
        Choice1.SetActive(false);
        Choice2.SetActive(false);
        ContinueButton.SetActive(false);
        Button1.onClick.AddListener(ChooseOption1);
        Button2.onClick.AddListener(ChooseOption2);
        ContButton.onClick.AddListener(Continue);
    }

    void loop()
    {
    }

    public void Part1()
    {
        Debug.Log("Part1");
        TomText.fontSize = 35;
        TomText.text = "Hey! It's nice to see you again!";
        PlayerText1.text = "It's been a while, Tom!";
        PlayerText2.text = "Who are you?";
        choice = 1;
        Choosing();
        Debug.Log("Done with Part 1 :(");
    }
    
    void Part2a()
    {
        Debug.Log("2a");
        TomText.text = "Well some of us have succesful jobs.";
        cont = 1;
        Reading();
    }
    
    void Part2b()
    {
        Debug.Log("Starting 2b!!");
        TomText.text = "I'm your friend Tom! It figures you'd forget me already.";
        cont = 2;
        Reading();
    }
    
    void Part3()
    {
        Debug.Log("Part3");
        TomText.fontSize = 25;
        TomText.text = "I heard that your family is going through some tough times. I could pay you to do a few jobs for me.";
        PlayerText1.text = "What do you want me to do?";
        PlayerText2.text = "I don't need your help";
        choice = 2;
        Choosing();
    }

    void Part3c()
    {
        Debug.Log("3c");
        TomText.text = "Then why did you come here?";
        if (rememberedName==true)
        {
            TomText.text = "You're not in a place to be picky with the state of your farm.";
        }
        if (rememberedName == false)
        {
            TomText.text = "Come on! Help a friend out! I mean so much to you that you forgot my name, remember?";
        }
        cont = 2;
        Reading();
    }

    void Part4()
    {
        Debug.Log("Part4");
        TomText.fontSize = 26;
        TomText.text = "I'm running low on wood. If you can get me 20 planks of wood. I'll pay you $3.50.";
        PlayerText1.text = "Only $3.50!?!";
        PlayerText2.text = "Thanks, Tim!";
        choice = 3;
        Choosing();
    }

    void Part5a()
    {
        Debug.Log("5a");
        TomText.text = "Times are hard. Take what you can get, Ninnyhammer!";
    }

    void Part5b()
    {
        Debug.Log("5b");
        if (rememberedName == true)
        {
            TomText.text = "My name's Tom! Wow! I thought we were friends!!";
        }
        if (rememberedName == false)
        {
            if (playerName == "Jackie")
            {
                TomText.text = "Ugh! Whatever. It's fine. Have fun, Mackie.";
            }
            else if (playerName == "Mildred")
            {
                TomText.text = "Ugh! Whatever. It's fine. Have fun, Mildew.";
            }
            else if (playerName == "Walter")
            {
                TomText.text = "Ugh! Whatever. It's fine. Have fun, Waldo.";
            }
        }
    }
    
    public void ChooseOption1()
    {
        Debug.Log("ChooseOption1");
        if (choice==1)
        {
            Part2a();
            rememberedName = true;
        }
        else if (choice == 2)
        {
            Part4();
        }
        else if (choice == 3)
        {
            Part5a();
        }
        NotChoosing();
    }
    
    public void ChooseOption2() {
        Debug.Log("ChooseOption2");
        if (choice == 1)
        {
            Debug.Log("In the if :)");
            Part2b();
            rememberedName = false;
        }
        else if (choice == 2)
        {
           Part3c();
        }
        else if (choice == 3)
        {
            Part5b();
        }
        Debug.Log("About time for you to be done choosing :/");
        NotChoosing();
    }

    public void Continue()
    {
        Debug.Log("ContinueVoid");
        if (cont == 1)
        {
            Part3();
        }
        else if (cont == 2)
        {
            Part4();
        }
        NotReading();
    }
    
    void Choosing ()
    {
        Debug.Log("ChoosingVoid");
        Choice1.SetActive(true);
        Choice2.SetActive(true);
    }
    
    void Reading ()
    {
        Debug.Log("ReadingVoid");
        ContinueButton.SetActive(true);
    }
    
    void NotChoosing ()
    {
        Debug.Log("NotChoosingVoid");
        Choice1.SetActive(false);
        Choice2.SetActive(false);
    }
    
    void NotReading ()
    {
        Debug.Log("NotReadingVoid");
        ContinueButton.SetActive(false);
    }
}
