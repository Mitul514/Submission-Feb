﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  public static GameManager Instance { get; set; }

  private void Awake()
  {
    if (Instance == null)
      Instance = this;
    else
      Destroy(this);
  }

  private void Start()
  {
    
  }
}
