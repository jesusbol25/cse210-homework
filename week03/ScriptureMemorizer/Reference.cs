

public class Reference
{
    // 1. Private Variables
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // 2. CONSTRUCTOR A For un verse

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse; 
    }

    // 3. CONSTRUCTOR B For a range
    
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // 4. T0 show the reference
    public string GetDisplayText()
    {
        
        if (_verse == _endVerse)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}