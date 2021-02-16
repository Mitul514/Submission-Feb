using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
  public static GameController Instance;

  [SerializeField] private GameObject _playerPrefab;
  [SerializeField] private GameObject _playerSpawner;

  [SerializeField] private GameObject _levelPrefab;
  [SerializeField] private GameObject _levelSpawner;

  #region Events
  public event Action LoadLevel;
  public event Action LoadPlayer; 
  #endregion

  private void Awake()
  {
    Instance = this;
  }

  private void Start()
  {
    GameManager.Instance.GameTrigger += ShowGame; 
  }
  
  private void OnDestroy()
  {
    GameManager.Instance.GameTrigger -= ShowGame;
  }

  private void ShowGame()
  {
    StartCoroutine("SpawnLevelObjects");
  }

  private IEnumerator SpawnLevelObjects()
  {
    SpawnLevelPrefab();
    yield return new WaitForSeconds(1f);
    SpawnPlayerPrefab();
  }

  private void SpawnLevelPrefab()
  {
    var levelClone = Instantiate(_levelPrefab);
    levelClone.transform.parent = _levelSpawner.transform;
    LoadLevel?.Invoke();
  }

  private void SpawnPlayerPrefab()
  {
    var playerClone = Instantiate(_playerPrefab);
    playerClone.transform.parent = _playerSpawner.transform;
    LoadPlayer?.Invoke();
  }
}
