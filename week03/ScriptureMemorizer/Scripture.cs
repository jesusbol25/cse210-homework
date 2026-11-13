

using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitwords = text.Split(' ');
        foreach (string wordString in splitwords)
        {
            Word newword = new Word(wordString);
            _words.Add(newword);
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false) 
            {
                return false; 
            }
        }
        return true; 
    }

    public string GetDisplayText()
    {
        string fullText = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            fullText += word.GetDisplayText() + " ";
        }
        return fullText;
    }

    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                visibleWords.Add(word);
            }
        }

        if (visibleWords.Count < numberToHide)
        {
            numberToHide = visibleWords.Count;
        }

        Random random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int randomIndex = random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
            visibleWords.RemoveAt(randomIndex);
        }
    }
}