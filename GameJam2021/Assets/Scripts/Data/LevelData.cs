using UnityEngine;

[CreateAssetMenu(fileName = "Level Data", menuName = "Data/LevelData")]
public class LevelData : ScriptableObject
{
  public string LevelName;

  public NpcData[] NpcCount;
  
  public float PlayerSpeed;
}

[System.Serializable]
public class NpcData
{
  public string NpcName;
  public float NpcSpeed;
  public NpcType Type;
}
