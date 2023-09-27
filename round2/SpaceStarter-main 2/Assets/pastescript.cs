using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class pastescript : MonoBehaviour
{
    public UnityEngine.UI.InputField inputField;

    public void CopyToClipboard()
    {
        TextEditor textEditor = new TextEditor();
        textEditor.text = inputField.text;
        textEditor.SelectAll();
        textEditor.Copy();  //Copy string from textEditor.text to Clipboard
    }
 

    public void PasteFromClipboard()
    {
        TextEditor textEditor = new TextEditor();
        textEditor.multiline = true;
        textEditor.Paste();  //Copy string from Clipboard to textEditor.text
        inputField.text = textEditor.text;
    }
}
