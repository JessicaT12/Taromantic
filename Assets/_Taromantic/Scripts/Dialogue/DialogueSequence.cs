using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(
    fileName = "NewDialogueSequence",
    menuName = "Taromantic/Dialogue Sequence")]
public class DialogueSequence : ScriptableObject
{
    public List<DialogueLine> lines = new();
}