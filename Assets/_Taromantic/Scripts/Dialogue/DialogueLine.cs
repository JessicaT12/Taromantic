
using System;
using UnityEngine;

[Serializable]
public class DialogueLine
{
    public string speaker;

    [TextArea(3, 8)]
    public string text;

    [Header("Optional Visual Changes")]
    public Sprite background;
    public Sprite characterPortrait;

    [Range(0, 2)]
    public int portraitPosition;

    public bool clearPortraits;
}
