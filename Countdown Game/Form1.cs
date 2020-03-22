using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace Countdown_Game
{
    public partial class Form1 : Form
    {
        List<string> vowels = new List<string>();
        List<string> consonants = new List<string>();
        Dictionary<string, int> dict = new Dictionary<string, int>();

        private int MAX_ROUND = 4;
        private string vowelPatten = "[aeiou]";
        private string dictionary = @"C:\Users\OEM\Desktop\C# Projects\Dictionary.txt";
        private string anagramList = @"C:\Users\OEM\Desktop\C# Projects\anagram.txt";

        private string playAnotherGame = "Would you like to play another game?";
        private string pressOkOrCancel = "Press Ok to continue or Cancel to exit the program.";
        private string pressOkToExit = "Press Ok to exit the game.";
        private string play4GamesAlready = "OMG! You have played 4 games already!";

        int currentRound = 0;
        int totalScore = 0;

        string anagram = "";
       
        Regex regex;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //get random anagram from the list anagram.txt
            anagram = getRandomAnagram();

            //create a vowel patten to identify vowels from anagram.
            regex = new Regex(vowelPatten);

            //split a word into two parts; vowels and consonants 
            splitVowelsAndConsonant(anagram);

            //on the form, just make it easy for the users to see the number of characters (vowels or consonants) left.
            updateLeftCharacters();
        }
        //This method checks the provided anagram against words from the dictionary.txt
        //In this little program, I made this method to pick the correct one unless user did not finish picking vowels or consonants.
        //e.g we have an anagram of 6 characters but, we only pick 3 or 5 characters. In this case, the program will pick the most appropriate word.
        private void findLongestWord()
        {
            String line;
            StreamReader file = new StreamReader(dictionary);

            //loop through the dictionary.txt file to find the most appropriate word.
            while ((line = file.ReadLine()) != null)
            {
                string properWord = line;
                string anagram = txtAnagram.Text;
                //find out how difference between anagram and word from dictionary.
                checkTheDifference(anagram, properWord);
            }

            //for every word in the dictionary, I added them to a hashmap with key is the 'proper word' and value is the 'number of difference character'
            //e.g anagram = elhho and properWord = hello. So, the number of difference character between them is 5.
            //Then I iterate through the hashmap and grap the highest value.
            int tempLongestWord = dict.Values.Max();
            foreach (KeyValuePair<string, int> entry in dict)
            {
                if (entry.Value == tempLongestWord)
                {
                    txbResult.Text = entry.Key;
                    txbCurrentScore.Text = tempLongestWord.ToString();
                    totalScore += tempLongestWord;
                    dict.Clear();
                    break;
                }
            }
        }
        //This method used to find the number(score) of difference between anagram and proper word.
        private int checkTheDifference(string anagram, string properWord)
        {
            String tempProperWord = properWord;
            int score = 0;
            int numberOfDifference = 0;

            for (int i = 0; i < anagram.Length; i++)
            {
                if (anagram.Length >= properWord.Length)
                {
                    for (int z = 0; z < tempProperWord.Length; z++)
                    {
                        if (anagram[i].Equals(tempProperWord[z]))
                        {
                            //to find the number of difference, for every removal successfully, I added 1 to numberOfDiffernce variable
                            tempProperWord = tempProperWord.Remove(z, 1);
                            numberOfDifference++;
                            break;
                        }
                    }
                }
            }
            //Avoid adding duplicated key
            if (!dict.ContainsKey(properWord))
                dict.Add(properWord, numberOfDifference);
            return score;
        }
        
        //get random anagram from the list.
        private string getRandomAnagram()
        {
            string word;
            string[] lines = File.ReadAllLines(anagramList);
            Random random = new Random();
            word = lines[random.Next(lines.Length)];
            return word;
        }

        //start new game and reset some of the fields such as current score, but keep the total score.
        //provide message box for user to make decision whether keep playing or exit the program.
        private void startNewGame()
        {
            MessageBoxResult messageBox = MessageBox.Show(pressOkOrCancel, playAnotherGame, MessageBoxButton.OKCancel);
            if (messageBox == MessageBoxResult.Cancel)
                this.Close();
            else if (messageBox == MessageBoxResult.OK)
            {
                //if reach 4 rounds then exit the program.
                //keep playing game is not good for your health.
                if (currentRound == MAX_ROUND)
                {
                    MessageBoxResult messageReached4Games = MessageBox.Show(pressOkToExit, play4GamesAlready, MessageBoxButton.OK);
                    if (messageReached4Games == MessageBoxResult.OK)
                        this.Close();
                }
                else
                    resetGame();
            }
        }

        //Reset some fields back to normal including get new anagram etc...
        private void resetGame()
        {
            txbCurrentScore.Text = "0";
            txtAnagram.Text = "";
            txbResult.Text = "";
            //because, I made the consonant and vowel buttons to disable stage when there is no character left.
            //Thus, when a new game started, I switched these button back to normal stage.
            btnConsonant.Enabled = true;
            btnVowel.Enabled = true;
            anagram = getRandomAnagram();
            splitVowelsAndConsonant(anagram);
            updateLeftCharacters();

        }

        //Allow user to play up to 4 rounds then exit the game.
        private void newRound()
        {
            if (currentRound == MAX_ROUND)
            {
                MessageBoxResult m = MessageBox.Show(pressOkToExit, play4GamesAlready, MessageBoxButton.OK);
                if (m == MessageBoxResult.OK)
                    this.Close();
            }
            else
                currentRound++;
            txbRound.Text = currentRound.ToString();
        }

        //split an anagram into 2 parts; vowels and consonant for an ease when click the vowel or consonant button.
        private void splitVowelsAndConsonant(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                String temp = word[i].ToString();
                //created a regex to detect vowels.
                if (regex.IsMatch(temp))
                    vowels.Add(temp);
                else
                    consonants.Add(temp);
            }
        }

        //show the number of characters (vowel and consonant) left for users.
        private void updateLeftCharacters()
        {
            btnVowel.Text = "vowels (" + vowels.Count() + ")";
            btnConsonant.Text = "consonants (" + consonants.Count() + ")";
        }

        //get a consonant character and when there is no character left, the program switches this button to disable stage.
        private void btnConsonant_Click(object sender, EventArgs e)
        {
            if (consonants.Count > 0)
            {
                txtAnagram.Text += consonants.ElementAt(0);
                consonants.RemoveAt(0);
                if (consonants.Count == 0)
                {
                    btnConsonant.Enabled = false;
                }
            }
            updateLeftCharacters();
        }

        //Same as consonant button.
        private void btnVowel_Click(object sender, EventArgs e)
        {
            if (vowels.Count > 0)
            {
                txtAnagram.Text += vowels.ElementAt(0);
                vowels.RemoveAt(0);
                if (vowels.Count == 0)
                {
                    btnVowel.Enabled = false;
                }
            }
            updateLeftCharacters();
        }

        //Find the proper word based on anagram.
        //Start new game and also checking for 4 rounds.
        private void btnFindResult_Click(object sender, EventArgs e)
        {
            findLongestWord();
            txbTotalScore.Text = totalScore.ToString();
            newRound();
            startNewGame();
        }
    }
}
