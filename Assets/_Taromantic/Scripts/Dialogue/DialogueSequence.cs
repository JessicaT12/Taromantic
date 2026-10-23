
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(
    fileName = "NewDialogueSequence",
    menuName = "Taromantic/Dialogue Sequence")]
public class DialogueSequence : ScriptableObject
{
    [Header("Identification")]
    public string sequenceID;

    [Header("Dialogue")]
    public List<DialogueLine> lines = new();

    [Header("Story Progression")]
    public DialogueSequence nextSequence;
}
