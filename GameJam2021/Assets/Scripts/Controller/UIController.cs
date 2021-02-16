using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
  public static UIController Instance;

  [SerializeField] private Button _playButton;
  [SerializeField] private Button _optionButton;
  [SerializeField] private Button _exitButton;

  private void Awake()
  {
    Instance = this;
  }

  private void Start()
  {
    GameManager.Instance.MenuTrigger += ShowMenu;
  }

  private void OnDestroy()
  {
    GameManager.Instance.MenuTrigger -= ShowMenu;
  }

  private void ShowMenu()
  {
    InstantiateMenu();
    _playButton.onClick.AddListener(OnPlayClick);
    _optionButton.onClick.AddListener(OnOptionClick);
    _exitButton.onClick.AddListener(OnExitClick);
  }

  private void InstantiateMenu()
  {
  }

  private void OnExitClick()
  {
  }

  private void OnOptionClick()
  {
  }

  private void OnPlayClick()
  {
    GameManager.Instance._states = States.GameState;
  }
}
