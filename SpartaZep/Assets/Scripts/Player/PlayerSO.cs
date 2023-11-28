using UnityEngine;

[CreateAssetMenu(fileName = "Player", menuName = "Player System/Player")]
public class PlayerSO : ScriptableObject
{

    [field: SerializeField] public float speed { get; set; }
    [field: SerializeField] public string playerName { get; set; }
    [field: SerializeField] public CharacterName characterName { get; set; }

    // [field: SerializeField] public GameObject gobject { get; set; }


}