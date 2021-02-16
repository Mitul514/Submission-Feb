using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  public static GameManager Instance { get; set; }

  public States _states = States.None;

  public event Action MenuTrigger; 
  public event Action GameTrigger; 
  public event Action PauseTrigger; 
  public event Action GameOverTrigger; 

  private void Awake()
  {
    if (Instance == null)
      Instance = this;
  }

  private void Start()
  {
    _states = States.MenuState;
  }

  private void Update()
  {
    switch (_states)
    {
      case States.MenuState:
        MenuTrigger?.Invoke();
        break;
      case States.GameState:
        GameTrigger?.Invoke();
        break;
      case States.PauseState:
        PauseTrigger?.Invoke();
        break;
      case States.GameOverState:
        GameOverTrigger?.Invoke();
        break;
      case States.None:
        break;
      default:
        break;
    }
  }
}
