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
    int Option;
    int choice;
    bool rememberedName;
    bool doneReading = false;
    string playerName = "Jackie";

    void Start() {
        Option = 0;
        choice = 0;
        Choice1.SetActive(false);
        Choice2.SetActive(false);
        ContinueButton.SetActive(false);
    }

    public void Part1()
    {
        TomText.fontSize = 35;
        TomText.text = "Hey! It's nice to see you again!";
        PlayerText1.text = "It's been a while, Tom!";
        PlayerText2.text = "Who are you?";
        Choosing();
        Debug.Log("Done with Part 1 :(");
    }

    void Part2a()
    {
        TomText.text = "Well some of us have succesful jobs.";
        while (doneReading == false)
        {
            Reading();
        }
        doneReading = false;
        StartCoroutine(Part3());
    }

    void Part2b()
    {
        Debug.Log("Starting 2b!!");
        TomText.text = "I'm your friend Tom! It figures you'd forget me already.";
        while (doneReading == false)
        {
            Debug.Log("Oh no! I'm stuck in a while loop. >:(");
            Reading();
        }
        doneReading = false;
        StartCoroutine(Part3());
    }

    IEnumerator Part3()
    {
        TomText.fontSize = 25;
        TomText.text = "I heard that your family is going through some tough times. I could pay you to do a few jobs for me.";
        yield return true;
        PlayerText1.text = "What do you want me to do?";
        PlayerText2.text = "I don't need your help";
        Choosing();
        choice = 2;
    }

    IEnumerator Part3c()
    {
        TomText.text = "Then why did you come here?";
        yield return new WaitForSeconds(3);
        if (rememberedName==true)
        {
            TomText.text = "You're not in a place to be picky with the state of your farm.";
        }
        if (rememberedName == false)
        {
            TomText.text = "Come on! Help a friend out! I mean so much to you that you forgot my name, remember?";
        }
        yield return new WaitForSeconds(5);
        Part4();
    }

    void Part4()
    {
        TomText.text = "I'm running low on wood. If you can get me 20 planks of wood. I'll pay you $3.50.";
        PlayerText1.text = "Only $3.50!?!";
        PlayerText2.text = "Thanks, Tim!";
        Choosing();
        choice = 3;
    }

    void Part5a()
    {
        TomText.text = "Times are hard. Take what you can get, Ninnyhammer!";
    }

    void Part5b()
    {
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
        Debug.Log("In the void :)");
        if (choice == 1)
        {
            Debug.Log("In the if :)");
            Part2b();
            rememberedName = false;
        }
        else if (choice == 2)
        {
            StartCoroutine(Part3c());
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
        doneReading = true;
    }

    void Choosing ()
    {
        Choice1.SetActive(true);
        Choice2.SetActive(true);
        choice++;
        Debug.Log(choice);
    }

    void Reading ()
    {
        ContinueButton.SetActive(true);
    }

    void NotChoosing ()
    {
        Choice1.SetActive(false);
        Choice2.SetActive(false);
    }

    void NotReading ()
    {
        ContinueButton.SetActive(false);
    }
}
