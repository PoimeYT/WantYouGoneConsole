using System;
using System.Collections.Generic; // Needed for List<T>
using System.Threading;
using System.Threading.Tasks;
using NAudio.Wave;  // If you use NAudio for MP3 playback

class Program
{
    static void Main(string[] args)
    {
        // Set terminal colors and font
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();

        // Display placeholders for lyrics synced with the music
        SyncLyrics();

        Console.Title = "Forms FORM-29827281-12-2";

        // Play the sound
        PlayMusic(@"Resources\song.wav"); // Ensure this path is correct
    }

    static void PlayMusic(string filePath)
    {
        try
        {
            using (var audioFile = new AudioFileReader(filePath))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);

                // Set the volume (0.0 is mute, 1.0 is full volume)
                outputDevice.Volume = 0.4f;  // Adjust volume to 40%

                outputDevice.Play();

                // Wait for the music to finish
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    private static async void SyncLyrics()
    {
        await Task.Delay(0); // Initial delay before starting the lyrics

        // List of initial lyrics
        var firstLyrics = new List<string>
        {
            "Forms FORM-29827281-12-2:",
            "Notice of Dismissal",
            "",
            "Well here we are again",
            "It's always such a pleasure",
            "Remember when you tried",
            "to kill me twice?",
            "Oh how we laughed and laughed",
            "Except I wasn't laughing",
            "Under the circumstances",
            "I've been shockingly nice"
        };

        // List of delays for each corresponding lyric line (in milliseconds)
        var firstDelays = new List<int>
        {
            1000,
            500,
            1000,
            1000, // line 1
            1000, // line 2
            300,  // line 3
            1500, // line 4
            800,  // line 5
            1000, // line 6
            300,  // line 7
            1000  // line 8
        };

        // List of character delays for each corresponding lyric line (in milliseconds)
        var firstCharDelays = new List<int>
        {
            50,
            50,
            50,
            50,   // Delay between characters for line 1
            50,   // Delay between characters for line 2
            50,   // Delay between characters for line 3
            70,   // Delay between characters for line 4
            50,   // Delay between characters for line 5
            50,   // Delay between characters for line 6
            50,   // Delay between characters for line 7
            90    // Delay between characters for line 8
        };

        // Check if all lists are of the same length
        if (firstLyrics.Count != firstDelays.Count || firstLyrics.Count != firstCharDelays.Count)
        {
            Console.WriteLine("Error: The number of lyrics, delays, and character delays must match.");
            return; // Exit the method if lengths do not match
        }

        // Display the first set of lyrics with a typing effect
        for (int i = 0; i < firstLyrics.Count; i++)
        {
            await TypeWriterEffect(firstLyrics[i], firstCharDelays[i]); // Use the specific character delay for this line
            await Task.Delay(firstDelays[i]); // Delay between lines based on the corresponding value in delays list
        }

        // Clear the console after the first set of lyrics
        Console.Clear();
        Console.Title = "...";

        // List of additional lyrics
        var secondLyrics = new List<string>
        {
            "You want your freedom?",
            "Take it",
            "That's what I'm counting on",
            "",
            "I used to want you dead",
            "but",
            "Now I only want you gone"
        };

        // List of delays for each corresponding additional lyric line (in milliseconds)
        var secondDelays = new List<int>
        {
            1000, // line 1 
            1500, // line 2!
            300,  // line 3!
            3000, // line 4!
            1000, // line 5
            300, // line 6
            5000,  // line 7
        };

        // List of character delays for each corresponding additional lyric line (in milliseconds)
        var secondCharDelays = new List<int>
        {
            60,   // Delay between characters for line 1
            70,   // Delay between characters for line 2
            60,   // Delay between characters for line 3
            60,   // Delay between characters for line 4
            50,   // Delay between characters for line 5
            50,   // Delay between characters for line 6
            150,    // Delay between characters for line 7
        };

        // Display the second set of lyrics with a typing effect
        for (int i = 0; i < secondLyrics.Count; i++)
        {
            await TypeWriterEffect(secondLyrics[i], secondCharDelays[i]); // Use the specific character delay for this line
            await Task.Delay(secondDelays[i]); // Delay between lines based on the corresponding value in delays list
        }

        // Clear 2nd set of lyrics
        Console.Clear();

        // List of 3rd additional lyrics
        var thirdLyrics = new List<string>
        {
            "She was a lot like you",
            "(Maybe not quite as heavy)",
            "Now little Caroline is in here too",
            "One day they woke me up",
            "So I could live forever",
            "It's such a shame the same",
            "Will never happen to you"
        };

        // List of delays for each corresponding additional lyric line (in milliseconds)
        var thridDelays = new List<int>
        {
            800, // line 1 
            800, // line 2!
            1400,  // line 3!
            1500, // line 4!
            1000, // line 5
            300, // line 6
            1500,  // line 7
        };

        // List of character delays for each corresponding additional lyric line (in milliseconds)
        var thridCharDelays = new List<int>
        {
            60,   // Delay between characters for line 1
            70,   // Delay between characters for line 2
            60,   // Delay between characters for line 3
            60,   // Delay between characters for line 4
            50,   // Delay between characters for line 5
            50,   // Delay between characters for line 6
            80,    // Delay between characters for line 7
        };

        // Display the second set of lyrics with a typing effect
        for (int i = 0; i < thirdLyrics.Count; i++)
        {
            await TypeWriterEffect(thirdLyrics[i], thridCharDelays[i]); // Use the specific character delay for this line
            await Task.Delay(thridDelays[i]); // Delay between lines based on the corresponding value in delays list
        }

        // Clear 3rd set of lyrics and prints the top text
        Console.Clear();

        Console.Title = "Severance Package Details"; 

        Console.WriteLine("Severance Package Details:");
        Console.WriteLine("");

        // List of 4th additional lyrics
        var fourthLyrics = new List<string>
        {
            "You've got your",
            "short sad",
            "life left",
            "That's what I'm counting on",
            "I'll let you get right to it",
            "Now I only want you gone",
        };

        // List of delays for each corresponding additional lyric line (in milliseconds)
        var fourthDelays = new List<int>
        {
            300, // line 1 
            300, // line 2!
            1000,  // line 3!
            2000, // line 4!
            1600, // line 5
            7000, // line 6
        };

        // List of character delays for each corresponding additional lyric line (in milliseconds)
        var fourthCharDelays = new List<int>
        {
            80,   // Delay between characters for line 1
            100,   // Delay between characters for line 2
            150,   // Delay between characters for line 3
            60,   // Delay between characters for line 4
            50,   // Delay between characters for line 5
            50,   // Delay between characters for line 6
        };

        // Display the second set of lyrics with a typing effect
        for (int i = 0; i < fourthLyrics.Count; i++)
        {
            await TypeWriterEffect(fourthLyrics[i], fourthCharDelays[i]); // Use the specific character delay for this line
            await Task.Delay(fourthDelays[i]); // Delay between lines based on the corresponding value in delays list
        }

        // Clear 4th set of lyrics
        Console.Clear();
        Console.Title = "[REDACTED]";

        // List of 5th additional lyrics
        var fithLyrics = new List<string>
        {
            "Goodbye my only friend",
            "Oh, did you think I meant you?",
            "That would be funny",
            "if it weren't so sad",
            "Well you have been replaced",
            "I don't need anyone now",
            "When I delete you maybe",
            "[REDACTED]"
        };

        // List of delays for each corresponding additional lyric line (in milliseconds)
        var fithDelays = new List<int>
        {
            800, // line 1 
            300, // line 2!
            800,  // line 3!
            800, // line 4!
            1000, // line 5
            1000, // line 6
            400,
            1600
        };

        // List of character delays for each corresponding additional lyric line (in milliseconds)
        var fithCharDelays = new List<int>
        {
            50,   // Delay between characters for line 1
            70,   // Delay between characters for line 2
            50,   // Delay between characters for line 3
            60,   // Delay between characters for line 4
            50,   // Delay between characters for line 5
            50,   // Delay between characters for line 6
            50,   // Delay between characters for line 7
            200,   // Delay between characters for line 6
        };

        // Display the second set of lyrics with a typing effect
        for (int i = 0; i < fithLyrics.Count; i++)
        {
            await TypeWriterEffect(fithLyrics[i], fithCharDelays[i]); // Use the specific character delay for this line
            await Task.Delay(fithDelays[i]); // Delay between lines based on the corresponding value in delays list
        }

        // Clear 5th set of lyrics
        Console.Clear();
        Console.Title = "...";

        // List of 6th additional lyrics
        var sixthLyrics = new List<string>
        {
            "Go make some new disaster",
            "That's what I'm counting on",
            "You're someone else's problem",
            "Now I only want you gone",
            "Now I only want you gone",
            "Now I only want you"
        };

        // List of delays for each corresponding additional lyric line (in milliseconds)
        var sixthDelays = new List<int>
        {
            2500, // line 1 
            3000, // line 2!
            800,  // line 3!
            2500, // line 4!
            3000, // line 5
            0, // line 6
        };

        // List of character delays for each corresponding additional lyric line (in milliseconds)
        var sixthCharDelays = new List<int>
        {
            80,   // Delay between characters for line 1
            50,   // Delay between characters for line 2
            80,   // Delay between characters for line 3
            80,   // Delay between characters for line 4
            80,   // Delay between characters for line 5
            80,   // Delay between characters for line 6
        };

        // Display the second set of lyrics with a typing effect
        for (int i = 0; i < sixthLyrics.Count; i++)
        {
            await TypeWriterEffect(sixthLyrics[i], sixthCharDelays[i]); // Use the specific character delay for this line
            await Task.Delay(sixthDelays[i]); // Delay between lines based on the corresponding value in delays list
        }


        // Clear 5th set of lyrics
        Console.Clear();
        Console.Title = "g o n e";


        // List of 6th additional lyrics
        var goneLyrics = new List<string>
        {
            "",
            "",
            "",
            "",
            "",
            "                   gone"
        };

        // List of delays for each corresponding additional lyric line (in milliseconds)
        var goneDelays = new List<int>
        {
            0, // line 1 
            0, // line 2!
            0,  // line 3!
            0, // line 4!
            0, // line 5
            0, // line 6
        };

        // List of character delays for each corresponding additional lyric line (in milliseconds)
        var goneCharDelays = new List<int>
        {
            0,   // Delay between characters for line 1
            0,   // Delay between characters for line 2
            0,   // Delay between characters for line 3
            0,   // Delay between characters for line 4
            0,   // Delay between characters for line 5
            0,   // Delay between characters for line 6
        };

        // Display the second set of lyrics with a typing effect
        for (int i = 0; i < sixthLyrics.Count; i++)
        {
            await TypeWriterEffect(goneLyrics[i], goneCharDelays[i]); // Use the specific character delay for this line
            await Task.Delay(goneDelays[i]); // Delay between lines based on the corresponding value in delays list
        }
    }

    private static async Task TypeWriterEffect(string text, int delay)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            await Task.Delay(delay); // Wait for the specified character delay
        }
        Console.WriteLine(); // Move to the next line after finishing the text
    }
}
