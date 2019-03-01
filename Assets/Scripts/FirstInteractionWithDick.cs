using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstInteractionWithDick : MonoBehaviour
{
    public Text DickText;
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
    string playerName = "Jackie";

    void Start()
    {
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
        DickSize(35);
        DickText.text = "Do you need some wood?";
        PlayerText1.text = "Yeah. I heard you have the best wood around.";
        PlayerText2.text = "Tom sent me here to get some.";
        choice = 1;
        Choosing();
    }

    void Part2a()
    {
        DickText.text = "Why thank you! I pride myself on my wood.";
        cont = 1;
        Reading();
    }

    void Part2b()
    {
        DickText.text = "Ah, Tom has always liked my wood.";
        cont = 1;
        Reading();
    }

    void Part3()
    {
        DickText.text = "What kind of wood are you looking for?";
        PlayerText1.text = "I was told to get 20 planks of wood";
        PlayerText2.text = "Um... well... I'm actually interesting in more than one type of wood...";
        choice = 2;
        Choosing();
    }

    void Part4a()
    {
        DickText.text = "Great! That will be $3.00";
    }

    void Part4b()
    {
    }

    void Part4c()
    {

    }

    void Part5()
    {

    }

    public void ChooseOption1()
    {
        NotChoosing();
        if (choice == 1)
        {
            Part2a();
        }
        else if (choice == 2)
        {
            Part4a();
        }
    }

    public void ChooseOption2()
    {
        NotChoosing();
        if (choice==1)
        {
            Part2b();
        }
        else if (choice == 2)
        {
            Part4b();
        }
    }

    public void Continue()
    {
        if (cont == 1)
        {
            Part3();
        }
    }

    void Choosing()
    {
        Choice1.SetActive(true);
        Choice2.SetActive(true);
    }

    void Reading()
    {
        ContinueButton.SetActive(true);
    }

    void NotChoosing()
    {
        Choice1.SetActive(false);
        Choice2.SetActive(false);
    }

    void NotReading()
    {
        ContinueButton.SetActive(false);
    }

    void DickSize(int girth)
    {
        DickText.fontSize = girth;
    }
}
