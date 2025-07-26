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
        foreach (string word in text.Split(" "))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomNumbers(int numberToHide)
    {
        Random rand = new Random();
        int isHiddenCount = 0;
        while (isHiddenCount < numberToHide)
        {
            int index = rand.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                isHiddenCount++;
            }
        }
    }
    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + "";
        foreach (var word in _words)
        {
            result += word.GetDisplayText() + "";
        }
        return result;
    }
    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}