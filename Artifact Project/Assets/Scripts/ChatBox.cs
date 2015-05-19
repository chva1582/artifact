﻿// This script creates Fezzik's chat panel.  Fezzik is an AI which is 
// controlled in the folder AIMLbot.

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChatBox : MonoBehaviour 
{
	private Chatbot bot;
	public GameObject messBox;
	private Text messBoard;
	public string mess;
	public string ask;
	private string answer;
	public GameObject field;
	private InputField inputField;
	private Vector2 scrollPosition;

	void Start () 
	{
		inputField = field.GetComponent<InputField>();
		messBoard = messBox.GetComponent<Text>();
		bot = new Chatbot();
	}

	public void Send()
	{
		mess += "Me: " + ask + "\n" + "\n";
		answer = bot.getOutput(ask);
		mess += "Fezzik: " + answer + "\n" + "\n";
		inputField.text = "";
	}

	public void changeAsk(string arg)
	{
		ask = arg;
	}

	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyUp(KeyCode.KeypadEnter))
		{
			Send();
		}
		messBoard.text = mess;
	}
}