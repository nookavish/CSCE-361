﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SliderScript : MonoBehaviour, ISelectHandler, IDeselectHandler, IPointerDownHandler, IPointerUpHandler {

	public AudioSource source;
	public Slider slideFX;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnSelect(BaseEventData eventData) {
		
	}

	public void OnDeselect(BaseEventData eventData) {
		
	}

	public void OnPointerDown(PointerEventData eventData) {
		//Debug.Log ("slider clicked");
	}

	public void OnPointerUp(PointerEventData eventData) {
		//Debug.Log ("slider unclicked");
		source.volume = slideFX.value;
		source.Play ();
	}
}
