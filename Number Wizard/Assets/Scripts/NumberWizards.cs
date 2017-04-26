using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizards : MonoBehaviour
{

	public int max = 10, min = 1;

	int _guessedNumber;
	int _guessMin, _guessMax;
	// Use this for initialization
	void Start ()
	{
		print ("Welcome to My first Console Game : Number Wizard");
		print ("Press Up for heigher, Down for Lower and return/enter for equal");

		// init Numbers

		print (" Pick some randome number in your head between " + min + " And " + max);

		// fixing MAX edge guess number 
		max += 1;
		_guessedNumber = (int)max / 2;
		_guessMin = min;
		_guessMax = max;

		print (" Is your nuber Heigher, Lower or Equal to " + _guessedNumber);

		print ("Press 'R' To Reset");
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			_guessMin = _guessedNumber;
			_guessedNumber = (_guessMin + _guessMax) / 2;

			//print ("min" + _guessMin + "  max " + _guessMax);
			print (" Is your nuber Heigher, Lower or Equal to " + _guessedNumber);

		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			_guessMax = _guessedNumber;
			_guessedNumber = (_guessMin  + _guessMax) /2;

			//print ("min" + _guessMin + "  max " + _guessMax);
			print (" Is your nuber Heigher, Lower or Equal to " + _guessedNumber);

		} else if (Input.GetKeyDown(KeyCode.Return)) {
			print ("your number is " + _guessedNumber);

		} else if(Input.GetKeyDown(KeyCode.R)){

			print ("Game is restarting ....");
			print (" Is your nuber Heigher, Lower or Equal to " + _guessedNumber);

			//print ("min" + min + "  max " + max);

			_guessMin = min;
			_guessMax = max;
			_guessedNumber = (_guessMin + _guessMax ) /2;
		}
			


		// Enable Next Input
	}
}
