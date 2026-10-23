using TMPro;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private TMP_Text speakerText;
    [SerializeField] private TMP_Text dialogueText;

    [Header("Dialogue")]
    [SerializeField] private DialogueSequence startingDialogue;

    [SerializeField]
    private VNPresentationController presentation;

    private DialogueSequence currentDialogue;
    private int currentLineIndex;

    private void Start()
    {
        if (startingDialogue != null)
        {
            StartDialogue(startingDialogue);
        }
    }

    public void StartDialogue(DialogueSequence sequence)
    {
        currentDialogue = sequence;
        currentLineIndex = 0;

        ShowCurrentLine();
    }

    public void NextLine()
    {
        if (currentDialogue == null)
            return;

        currentLineIndex++;

        if (currentLineIndex >= currentDialogue.lines.Count)
        {
            EndDialogue();
            return;
        }

        ShowCurrentLine();
    }

    private void ShowCurrentLine()
    {
        DialogueLine line =
            currentDialogue.lines[currentLineIndex];

        speakerText.text = line.speaker;
        dialogueText.text = line.text;

        if (line.clearPortraits)
        {
            presentation.ClearPortraits();
        }

        if (line.background != null)
        {
            presentation.SetBackground(line.background);
        }

        if (line.characterPortrait != null)
        {
            presentation.SetPortrait(
                line.characterPortrait,
                line.portraitPosition);
        }
    }

    private void EndDialogue()
    {
        speakerText.text = "";
        dialogueText.text = "";

        currentDialogue = null;

        Debug.Log("Dialogue finished.");
    }
}