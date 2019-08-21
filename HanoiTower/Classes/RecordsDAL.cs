using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Cryptography;

namespace HanoiTower
{
    class RecordsDAL : CryptoClass
    {
        private new string path = Application.StartupPath + "\\Scores.dat";

        private string dataPath = Application.StartupPath + "\\Data.dat";

        private void ChangeEncryptedDataPath()
        {
            cryptoPath = path;
        }

        public void Save(Records objRec, Preferences objPref)
        {
            try
            {
                Encrypt(objRec.PlayerName);
                Encrypt("|" + objPref.NumberOfDisksDesired + "disks|");
                Encrypt(objRec.PlayerScore.ToString());
                Encrypt("<" + objRec.ElapsedPlayingTime + ">");
            }
            catch (IOException ioEx)
            {
                throw new IOException("Error while reading/writing:\n" + ioEx.Message);
            }
        }

        public void MinAndSecSeparation(Records objRec) // Separating minutes from seconds of the elapsed time:
        {
            string current_value = null;

            objRec.ElapsedMinutes = 0;
            objRec.ElapsedSeconds = 0;

            for (int i = 0; i < objRec.ElapsedPlayingTime.Length; i++)
            {
                if (objRec.ElapsedPlayingTime.Substring(i, 1) != ":")
                {
                    current_value += objRec.ElapsedPlayingTime.Substring(i, 1);
                }
                else
                {
                    // Found a ":", so what we've got until now are minutes
                    objRec.ElapsedMinutes = int.Parse(current_value);
                    current_value = null;
                }
            }
            // The loop is over, so the current_value variable stands for counting seconds
            objRec.ElapsedSeconds = int.Parse(current_value);
        }

        public bool RecordGeneralCheck(Records objRec, Preferences objPref)
        {
            try
            {
                ChangeEncryptedDataPath(); // Changing the path where the encrypted data will be stored

                // Check to see whether the encrypted files exhists or not
                CheckFileExistence(cryptoPath);
                CheckFileExistence(dataPath);

                if (CheckEmptyFile(dataPath)) // If the data file is empty, encrypted content must also be empty to avoid conflicts
                {
                    ErasingFile(cryptoPath); // Erasing everything that has been written to the file
                    return true;
                }

                if (CheckEmptyFile(cryptoPath)) // If the scores file is empty no record has been broken
                    return true;
                    
                objRec.Line = null;

                SetAllLists(objRec, objPref);
                GetLowestMinAndSec(objRec);
                GetLowestScore(objRec);
            }
            catch (IOException ioEx)
            {
                throw new IOException("Error while reading/writing:\n" + ioEx.Message);
            }
            
            if (objRec.PlayerScore > objRec.LowestScore)
            {
                return false; // Player didn't break any records
            }
            else if (objRec.PlayerScore == objRec.LowestScore)
            {
                if (objRec.ElapsedMinutes > objRec.LowestScore)
                {
                    return false;
                }
                else if (objRec.ElapsedMinutes == objRec.LowestMinute)
                {
                    if (objRec.ElapsedSeconds >= objRec.LowestSecond)
                        return false;
                }
            }
            else
            {
                if (objRec.ElapsedMinutes > objRec.LowestScore)
                {
                    return false;
                }
                else if (objRec.ElapsedMinutes == objRec.LowestMinute)
                {
                    if (objRec.ElapsedSeconds >= objRec.LowestSecond)
                        return false;
                }
            }

            return true; //Player broke a record
        }

        private void CheckFileExistence(string filePath)
        {
            if (!File.Exists(filePath))
            {
                // Creating file:
                var file = File.Create(filePath);
                file.Close();
            }
        }

        private bool CheckEmptyFile(string filePath)
        {
            using (System.IO.StreamReader file = new System.IO.StreamReader(filePath))
            {
                if (file.ReadToEnd() == String.Empty)
                    return true; // It's an empty file    
                else
                    return false;
            }
        }

        private void ErasingFile(string filePath)
        {
            try
            {
                File.WriteAllText(filePath, string.Empty);
            }
            catch(IOException ioEx)
            {
                MessageBox.Show(ioEx.Message, "Error while writing to file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReadFile(Records objRec)
        {
            byte[][] encryptedData = GetEncryptedData();
            List<string> decryptedDataList = new List<string>();
            string[] decryptedData = null;

            for (int i = 0; i < encryptedData.Length; i++)
            {
                if (encryptedData[i].Length != 0)
                    decryptedDataList.Add(Decrypt(encryptedData[i]));
            }

            decryptedData = decryptedDataList.ToArray();

            objRec.Line = decryptedData;
        }

        private void SetAllLists(Records objRec, Preferences objPref) // Get all the elapsed times and scores of the document (scores.txt) that refer accordingly to the number of disks specified on Preferences
        {
            #region Initializing lists
            objRec.Players = new List<string>();
            objRec.Scores = new List<int>();
            objRec.Minutes = new List<int>();
            objRec.Seconds = new List<int>();
            #endregion

            ChangeEncryptedDataPath(); // Changing the path where the encrypted data will be stored

            ReadFile(objRec);

            string value = null; // Current value being read from the file

            int colon = 0; // Used to check if the first ":" has been found, so we know that what's before refers to time in minutes

            int c = objRec.Line.Count() - 1; // while counter

            while (c >= 0)
            {
                if (objRec.Line[c] != String.Empty && objRec.Line[c] != null)
                {
                    if (objRec.Line[c] == ("|" + objPref.NumberOfDisksDesired + "disks|"))
                    {
                        objRec.Scores.Add(int.Parse(objRec.Line[c + 1].ToString())); // In the file, the score appear at the line below the disk number, so c+1 is used
                        objRec.Players.Add(objRec.Line[c - 1].ToString()); // In the file, the player name appear at the line above the disk number, so c-1 is used
                       
                        for(int i = 1; i < objRec.Line[c + 2].Length; i++)
                        {
                            if ((objRec.Line[c + 2].Substring(i, 1) != ">") && (objRec.Line[c + 2].Substring(i, 1) != ":"))
                            {
                                value += objRec.Line[c + 2].Substring(i, 1);
                            }
                            else // A colon has been found
                            {
                                colon++;
                                switch (colon)
                                {
                                    case 1: // It refers to a minute
                                        {
                                            objRec.Minutes.Add(int.Parse(value));
                                        }
                                        break;
                                    default: // Case 2 - It refers to a second
                                        {
                                            objRec.Seconds.Add(int.Parse(value));
                                        }
                                        break;
                                }

                                // Erasing the current value
                                value = null;
                            }
                        }
                        colon = 0;
                    }
                }
                c--;
            }
        }

        private int GetScoreAndTimeArraySize(Records objRec, Preferences objPref)
        {
            int arraySize = 0;

            int c = objRec.Line.Count() - 1; //while counter

            while(c != 0)
            {
                if (objRec.Line[c] != String.Empty && objRec.Line[c] != null)
                {
                    if (objRec.Line[c].ToString() == ("|" + objPref.NumberOfDisksDesired + "disks|"))
                    {
                        arraySize++;
                    }
                }
                c--;
            }

            return arraySize;
        }

        private void GetLowestMinAndSec(Records objRec)
        {
            objRec.LowestMinute = int.MaxValue;
            objRec.LowestSecond = int.MaxValue;

            int loopLimit = objRec.Minutes.Count();

            for (int i = 0; i < loopLimit; i++)
            {
                if (objRec.LowestMinute > objRec.Minutes[i])
                    objRec.LowestMinute = objRec.Minutes[i];

                if (objRec.LowestSecond > objRec.Seconds[i])
                    objRec.LowestSecond = objRec.Seconds[i];
            }

        }

        private void GetLowestScore(Records objRec)
        {
            objRec.LowestScore = int.MaxValue;

            int loopLimit = objRec.Scores.Count();

            for (int i = 0; i < loopLimit; i++)
            {
                if (objRec.LowestScore > objRec.Scores[i])
                    objRec.LowestScore = objRec.Scores[i];
            }
        }

        public bool BestSolutionCheck(Records objRec, Preferences objPref) //Check whether the user has done the best solution (lowest quantity of movements) or not
        { 
            int bestSolution = Convert.ToInt16( Math.Pow(2, objPref.NumberOfDisks) - 1 );

            if (objRec.PlayerScore == bestSolution)
                return true;
            else
                return false;
        }

        // THE METHODS BELOW ARE RELATED TO THE SELECTION OF THE BEST PLAYERS:

        public void GetTopPlayers(Records objRec, Preferences objPref)
        {
            //Checking to see if file exhists
            CheckFileExistence(path);

            // Setting the lists that will hold all the data (player name, score and elapsed time):
            SetAllLists(objRec, objPref);

            #region Selecting best players based on their scores and finishing times:
            /* OBS: Players with lower scores are upranked.
             * OBS²: In case of even scores, players with higher elapsed times are downranked.
             * */

            List<int> bestPlayersIndexes = new List<int>();
            bestPlayersIndexes = GetBestPlayerIndexes(objRec);

            #endregion
        }

        private List<int> GetBestPlayerIndexes(Records objRec)
        {
            List<int> bestPlayersIndexes = new List<int>();

            // If the number of records are below 10, there's no reason to select the top 10 players:
            int numberOfRecords = objRec.Players.Count();

            int c = numberOfRecords;
            if ((c = objRec.Players.Count()) <= 10)
            {
                while (c >= 0)
                {
                    bestPlayersIndexes.Add(c);

                    c--;
                }

                return bestPlayersIndexes;
            }

            // As the number of records is above 10, worst players will be removed from the lists:
            List<int> repeatedWorstScoresIndexes = new List<int>();
            int worstScore = int.MinValue;

            for (int i = 0; i < numberOfRecords; i++)
            {
                if (worstScore < objRec.Scores[i])
                {
                    repeatedWorstScoresIndexes.Clear(); // Removing all the elements from the list because worse score has been found
                    worstScore = objRec.Scores[i];
                    repeatedWorstScoresIndexes.Add(i);
                }
                else if (worstScore == objRec.Scores[i])
                {
                    repeatedWorstScoresIndexes.Add(i);
                }
            }

            if (repeatedWorstScoresIndexes.Count == 1)
            {
                // There aren't any repeated scores, so remove all the data that is related to this score:
                RemoveFromLists(objRec, repeatedWorstScoresIndexes[0]);

                // Recursive call:
                return GetBestPlayerIndexes(objRec);
            }
            else
            { 
                // There are repeated scores, so compare elapsed times between them:

                List<int> repeatedMinutesIndexes = new List<int>();
                int highestMinute = int.MinValue;

                for (int i = 0; i < repeatedWorstScoresIndexes.Count; i++)
                {
                    int currentIndex = repeatedWorstScoresIndexes[i];

                    if (highestMinute < objRec.Minutes[currentIndex])
                    {
                        repeatedMinutesIndexes.Clear(); // Removing all the elements from the list because a higher minute has been found
                        highestMinute = objRec.Minutes[currentIndex];
                        repeatedMinutesIndexes.Add(currentIndex);
                    }
                    else if (highestMinute == objRec.Minutes[currentIndex])
                    {
                        repeatedMinutesIndexes.Add(currentIndex);
                    }
                }

                if (repeatedMinutesIndexes.Count == 1)
                {
                    // There aren't any repeated minutes, so remove all the data that is related to this score:
                    RemoveFromLists(objRec, repeatedMinutesIndexes[0]);

                    // Recursive call:
                    return GetBestPlayerIndexes(objRec);
                }
                else
                {
                    /* There are repeated minutes, so delete the player with the highest second:
                     * OBS: Players with repeated seconds don't break any records, so seconds will not appear repeatedly: 
                     */
                    int indexToBeDeleted = 0;
                    int highestSecond = int.MinValue;

                    for (int i = 0; i < repeatedMinutesIndexes.Count; i++)
                    {
                        int currentIndex = repeatedMinutesIndexes[i];

                        if (highestSecond < objRec.Seconds[currentIndex])
                        {
                            highestSecond = objRec.Seconds[currentIndex];
                            indexToBeDeleted = currentIndex;
                        }
                    }

                    RemoveFromLists(objRec, repeatedMinutesIndexes[indexToBeDeleted]);

                    return GetBestPlayerIndexes(objRec);
                }
            }
        }

        private void RemoveFromLists(Records objRec, int index)
        {
            objRec.Players.RemoveAt(index);
            objRec.Scores.RemoveAt(index);
            objRec.Minutes.RemoveAt(index);
            objRec.Seconds.RemoveAt(index);
        }
    }
}
