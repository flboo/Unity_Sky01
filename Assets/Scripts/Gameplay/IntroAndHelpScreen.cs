﻿using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class IntroAndHelpScreen : MonoBehaviour 
{
	public void OnTutorialClick()
	{
		if (InputManager.instance.canInput ())
		{
			GameController.instance.OnCloseButtonPressed ();
			AudioManager.instance.PlayButtonClickSound ();
			GameDataManager.instance.isHelpRunning = 1;
			GameController.instance.SpawnUIScreen ("GamePlay_help", true);
		}
	}

	public void OnOkClick()
	{
		if (InputManager.instance.canInput ())
		{
			AudioManager.instance.PlayButtonClickSound ();
			GameController.instance.OnCloseButtonPressed ();
			GameDataManager.instance.isHelpRunning = 1;
			GameController.instance.SpawnUIScreen ("Classic_HelpIntro_2", true);
		}
	}

	public void OnhelpComplete()
	{
		if (InputManager.instance.canInput ())
		{
			AudioManager.instance.PlayButtonClickSound ();
			GameController.instance.OnCloseButtonPressed ();
			GameDataManager.instance.isHelpRunning = 0;
			GameController.instance.SpawnUIScreen ("GamePlay", true);
		}
	}

	public void OnBombModeIntroScreen()
	{
		if (InputManager.instance.canInput ())
		{
			AudioManager.instance.PlayButtonClickSound ();
			GameController.instance.OnCloseButtonPressed ();
			GamePlay.GamePlayMode = GameMode.bomb;
			GameDataManager.instance.isHelpRunning = 0;
			GameController.instance.SpawnUIScreen ("GamePlay", true);
		}
	}

	public void OnPlusModeIntroScreen()
	{
		if (InputManager.instance.canInput ())
		{
			AudioManager.instance.PlayButtonClickSound ();
			GameController.instance.OnCloseButtonPressed ();
			GamePlay.GamePlayMode = GameMode.plus;
			GameDataManager.instance.isHelpRunning = 0;
			GameController.instance.SpawnUIScreen ("GamePlay", true);
		}
	}

	public void OnTimerModeIntroScreen()
	{
		if (InputManager.instance.canInput ())
		{
			AudioManager.instance.PlayButtonClickSound ();
			GameController.instance.OnCloseButtonPressed ();
			GamePlay.GamePlayMode = GameMode.timer;
			GameDataManager.instance.isHelpRunning = 0;
			GameController.instance.SpawnUIScreen ("GamePlay", true);
		}
	}

	public void OnClickSkip()
	{
		if (InputManager.instance.canInput ()) 
		{
			GameController.instance.OnCloseButtonPressed ();
			GameController.instance.SpawnUIScreen ("GamePlay", true);
			AudioManager.instance.PlayButtonClickSound ();
		}
	}

}
