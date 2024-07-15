using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

class Program
{
    public Program()
    {
        JoinArray();
        JoinList();
        JoinCharacters();
        JoinListOfStrings();
        JoinSpecificElements();
        JoinArrayOfAnObjects();
        JoinLinqAndIEnumerable();
        JoinRecords();
        Join();
        SearchContain();
        SearchStartsWith();
        SearchEndsWith();
        SearchIndexOf();
        SearchLastIndexOf();
    }

    static void Main(string[] args)
    {
        new Program();
    }

    void JoinArray()
    {
        string[] words = { "Hello", "world", "I", "am", "an", "Avid", "Learner" };
        string result = string.Join(" ", words);
        Console.WriteLine(result);
        Console.WriteLine(".................................");
    }

    void JoinList()
    {
        List<string> words = new List<string> { "Honesty", "is", "the", "best", "policy" };
        string result = string.Join(" ", words);
        Console.WriteLine(result);
        Console.WriteLine(".................................");
    }

    void JoinCharacters()
    {
        char[] chars = { 'C', '#', 'U', 'S', 'E', 'S', '.', 'N', 'E', 'T', 'F', 'R', 'A', 'M', 'E', 'W', 'O', 'R', 'K' };
        string result = string.Join("", chars);
        Console.WriteLine(result);
        Console.WriteLine(".................................");
    }

    void JoinListOfStrings()
    {
        string[] words = { "Tiger", "Lion", "Hawk", "Eagle", "Vulture" };
        string result = string.Join(",", words);
        Console.WriteLine(result);
        Console.WriteLine(".................................");
    }

    void JoinSpecificElements()
    {
        List<string> words = new List<string> { "The", "Weather", "is", "Warm", "and", "Dry", "but", "it", "gonna", "Rain" };
        int[] indices = { 1, 2, 5, 6, 7, 8, 9 };
        var selectedWords = indices.Select(index => words[index]);
        string result = string.Join(" ", selectedWords);
        Console.WriteLine(result);
        Console.WriteLine(".................................");
    }

    void JoinArrayOfAnObjects()
    {
        string[] values = { "3", "4.567", "true", "Falcon" };
        string result = string.Join("-", values);
        Console.WriteLine(result);
        Console.WriteLine(".................................");
    }

    void JoinLinqAndIEnumerable()
    {
        List<string> words = new List<string> { "sky", "motorbike", "owl", "clown", "sun", "running" };
        string result = string.Join(" ", words.Where(e => e.Length == 3));
        Console.WriteLine(result);
        Console.WriteLine(".................................");
    }

    void JoinRecords()
    {
        var users = new List<User> {
            new User("John Doe", "gardener"),
            new User("Roger Roe", "driver"),
            new User("Lucia Smith", "teacher")
        };

        var text = string.Join("\n", users.Select(u => $"{u.Name} - {u.Occupation}"));
        Console.WriteLine(text);
        Console.WriteLine(".................................");
    }
    public record User(string Name, string Occupation);
    void Join()
    {
        string name = "abhay";
        string lastname = "choudhary";
        Console.WriteLine("printing results");
        string result = string.Concat(name, lastname);
        Console.WriteLine(result);
        Console.WriteLine(".................................");
        Console.WriteLine(".................................");
    }
    //// SearchString
    // C# CONTAINS
    void SearchContain()
    {
        string text = "An old hawk in the sky";
        string word = "hawk";

        if (text.Contains(word))
        {
            Console.WriteLine($"The text contains the {word} word");
        }
        else
        {
            Console.WriteLine($"The text does not contain the {word} word");
            Console.WriteLine(".................................");
        }
    }

    void SearchStartsWith()
    {
        string text = "Discipline is the key to success";
        string word = "Discipline";
        if (text.StartsWith(word))
        {
            Console.WriteLine($"Yes!!! the starting of the text is with the word {word}.");
        }
        else
        {
            Console.WriteLine($"Sorry!!! the text does not start with the word {word}");
            Console.WriteLine(".................................");
        }
    }
    void SearchEndsWith()
    {
        string text = "Ever sunset brings the promise of new sunrise";
            string word = "sunrise";
        if (text.EndsWith(word))
        {
            Console.WriteLine($"YES!!!!! the text ends with the word{word}");
        }
        else
        {
            Console.WriteLine($"NO!!!! the text does not ends with the {word}");
            Console.WriteLine(".................................");
        }
    }
    void SearchIndexOf()
    {
        string text = "The punjab is the land of 5 rivers";
        int index = text.IndexOf("p");
        Console.WriteLine($"the fist index of the text is:{index}");
        Console.WriteLine(".................................");
    }
    void SearchLastIndexOf()
    {
        string text = "The punjab is the land of 5 rivers";
        int index = text.LastIndexOf("e");
        Console.WriteLine($"the last index of the text is:{index}");
        Console.WriteLine(".................................");
    }
}