﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsPopup : MonoBehaviour {
	//TODO:

	public void Open()
	{
        gameObject.SetActive(true);
    }
	public void Close()
	{
		gameObject.SetActive(false);
	}
}
