using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerService : MonoBehaviour
{

  private void Start()
  {
    GameController.Instance.LoadPlayer += SetPlayerData;
  }

  private void OnDestroy()
  {
    GameController.Instance.LoadPlayer -= SetPlayerData;
  }

  private void SetPlayerData()
  {
    //player behaviour creation
    //movement method create
    //collision detection create
  }
}
