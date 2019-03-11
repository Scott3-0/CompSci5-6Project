using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour {
	
	public string PlayerName = "Mysterious Person";
	
	public float volume = 0;
	public bool paused = false;
	
	public GameObject FullPanel;
	public GameObject MainMenu;
	public GameObject SettingsMenu;
	public GameObject NameChooser;
	public GameObject PauseButton;
	public GameObject PauseMenu;
	
	private GameObject CurrentMenu = null;//null means no menu is open
	
	public Slider VolumeSlider;
	
	public int Money = 350; //this is in cents!!!
	
	public void ChooseName(string newname) {
		PlayerName = newname;
		CloseMenus();
	}
	
	public string FormatMoney() {
		string str = Money.ToString();//TODO: make it not break when money is 0
		str = str.Insert(str.Length-2,".");
		return str;
	}
	
	// Use this for initialization
	void Start () {
		SwitchToMenu(MainMenu);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	//main menu
	
	private void SwitchToMenu(GameObject newmenu) {
		FullPanel.SetActive(true);
		if (CurrentMenu != null) {
			CurrentMenu.SetActive(false);
		}
		newmenu.SetActive(true);
		CurrentMenu = newmenu;
	}
	
	private void CloseMenus() {
		if(CurrentMenu != null){
			CurrentMenu.SetActive(false);
		}
		FullPanel.SetActive(false);
	}
	
	public void StartGame() {
		SwitchToMenu(NameChooser);
	}
	
	public void OpenSettings() {
		SwitchToMenu(SettingsMenu);
	}
	
	public void CloseSettings() {
		if(paused){
			SwitchToMenu(PauseMenu);
		} else {
			SwitchToMenu(MainMenu);
		}
	}
	
	public void OpenMainMenu() {
		SwitchToMenu(MainMenu);
	}
	
	public void QuitGame() {
		Debug.Log("Quitting (this won't do anything in the editor)");
		Application.Quit();
	}
	
	public void UpdateVolume() {
		volume = VolumeSlider.value;
	}
	
	public void OpenPauseMenu() {
		SwitchToMenu(PauseMenu);
	}
	
	public void Pause() {
		paused = true;
		SwitchToMenu(PauseMenu);
	}
	
	public void Unpause() {
		paused = false;
		CloseMenus();
	}
}
