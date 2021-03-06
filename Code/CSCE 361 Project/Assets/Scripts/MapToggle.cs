﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapToggle : MonoBehaviour {
	[SerializeField]
	private ToggleGroup toggles;
	[SerializeField]
	private Toggle toggle1, toggle2, toggle3, toggle4;
	[SerializeField]
	private Image mapImage;
	[SerializeField]
	private Sprite mapS, mapM, mapL, mapSIcon, mapMIcon, mapLIcon;

	[SerializeField]
	private Text joined1, joined2, joined3, joined4;
	private static bool isOneJoined = false, isTwoJoined = false, isThreeJoined = false, isFourJoined = false;

	private static string mapName;

	// Use this for initialization
	void Start () {

		//Set the default map name to the small map, since it is checked by default.
		mapName = mapS.name;

		toggle1.onValueChanged.AddListener ((value) => {
			if (value) {
				mapImage.sprite = mapSIcon;
				mapName = mapS.name;
			}
		});

		toggle2.onValueChanged.AddListener ((value) => {
			if (value) {
				mapImage.sprite = mapMIcon;
				mapName = mapM.name;
			}
		});

		toggle3.onValueChanged.AddListener ((value) => {
			if (value) {
				mapImage.sprite = mapLIcon;
				mapName = mapL.name;
			}
		});

		toggle4.onValueChanged.AddListener ((value) => {
			if (value) {
				int temp = Random.Range(1, 3);
				if (temp == 1) {
					mapName = mapS.name;
				} else if (temp == 2) {
					mapName = mapM.name;
				} else {
					mapName = mapL.name;
				}
			}
		});
	}

	void Update() {

		if (Input.GetKeyUp (KeyCode.Space)) isOneJoined = !isOneJoined;
        if (Input.GetButtonUp ("Start_P1")) isOneJoined = !isOneJoined;
        if (Input.GetButtonUp ("Start_P2")) isTwoJoined = !isTwoJoined;
        if (Input.GetButtonUp ("Start_P3")) isThreeJoined = !isThreeJoined;
        if (Input.GetButtonUp ("Start_P4")) isFourJoined = !isFourJoined;

		if (isOneJoined)
			joined1.text = "Joined";
		else
			joined1.text = "Not Joined";
		if (isTwoJoined)
			joined2.text = "Joined";
		else
			joined2.text = "Not Joined";
		if (isThreeJoined)
			joined3.text = "Joined";
		else
			joined3.text = "Not Joined";
		if (isFourJoined)
			joined4.text = "Joined";
		else
			joined4.text = "Not Joined";

	}

	public static string GetMapName() {
		return mapName;
	}

	public static bool getPlayerStatus(int n) {
		switch(n) {
		case 1:
			return isOneJoined;
		case 2: 
			return isTwoJoined;
		case 3: 
			return isThreeJoined;
		case 4:
			return isFourJoined;
		default:
			return false;
		}
	}
}


	