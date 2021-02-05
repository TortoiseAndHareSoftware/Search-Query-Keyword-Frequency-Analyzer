using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SEO_Analyzer
{
    public partial class SEOAnalyzerForm : Form
    {
        private int clicksToImpressions;
        private string formatString = "N0";
        private int NumberToTake = 50;

        public SEOAnalyzerForm()
        {
            InitializeComponent();
        }

        private void analyzeButton_Click(object sender, EventArgs e)
        {
            clicksToImpressions = Convert.ToInt32(totalImpressionsText.Text) / Convert.ToInt32(totalClicksText.Text);


            List<string> keywords = rawTextData.Text.Split('\n').ToList();
            List<SEOKeyWord> keywordObjects = new List<SEOKeyWord>();
            int errCount = 0;
            foreach (string item in keywords)
            {
                if (item.Contains("ohnut") || item.Contains("oh nut") || item.Contains("o nut"))
                {
                    continue;
                }

                string[] keywordPerformanceComponents = item.Split('\t').ToArray();

                try
                {
                    keywordObjects.Add(new SEOKeyWord
                    {
                        Keyword = keywordPerformanceComponents[0],
                        NumClicks = Convert.ToInt32(keywordPerformanceComponents[1]),
                        NumImpressions = Convert.ToInt32(keywordPerformanceComponents[2]),
                        ClickThroughRate = Convert.ToDecimal(keywordPerformanceComponents[3]),
                        AveragePosition = Convert.ToDecimal(keywordPerformanceComponents[4])
                    });

                }
                catch (Exception)
                {
                    errCount++;
                }

            }

            List<WeightedKeywordResult> wordFrequency = new List<WeightedKeywordResult>();

            // single word scoring
            foreach (var item in keywordObjects)
            {
                string[] words = item.Keyword.Split(' ').ToArray();
                string currentWordOrPhrase;
                int wordCount = 1;

                string firstWord = string.Empty;
                string secondWord = string.Empty;
                string thirdWord = string.Empty;
                string fourthWord = string.Empty;

                for (int i = 0; i < words.Length; i++)
                {
                    if (firstWord == string.Empty)
                    {
                        firstWord = words[i];
                    }
                    else if (secondWord == string.Empty)
                    {
                        secondWord = words[i];
                        wordCount = 2;
                    }
                    else if (thirdWord == string.Empty)
                    {
                        thirdWord = words[i];
                        wordCount = 3;
                    }
                    else if (fourthWord == string.Empty)
                    {
                        fourthWord = words[i];
                        wordCount = 4;
                    }
                    else
                    {
                        firstWord = secondWord;
                        secondWord = thirdWord;
                        thirdWord = fourthWord;
                        fourthWord = words[i];
                    }

                    currentWordOrPhrase = string.Join(" ", new[] { firstWord, secondWord, thirdWord, fourthWord }).Trim();

                    AddKeywordsToResults(wordFrequency, item, currentWordOrPhrase, wordCount);

                }





            }

            //// phrase point scoring

            //foreach (var item in keywordObjects)
            //{
            //    string[] words = item.Keyword.Split(' ').ToArray();
            //    string currentWordOrPhrase;
            //    int wordCount;


            //    switch (words.Length)
            //    {
            //        case 1:
            //            currentWordOrPhrase = $"{words[0]}";
            //            wordCount = 1;
            //            break;
            //        case 2:
            //            currentWordOrPhrase = $"{words[0]} {words[1]}";
            //            wordCount = 2;
            //            break;
            //        case 3:
            //            currentWordOrPhrase = $"{words[0]} {words[1]} {words[2]}";
            //            wordCount = 3;
            //            break;
            //        case 4:
            //            currentWordOrPhrase = $"{words[0]} {words[1]} {words[2]} {words[3]}";
            //            wordCount = 4;
            //            break;
            //        default:
            //            continue;
            //    }

            //    AddKeywordsToResults(wordFrequency, item, currentWordOrPhrase, wordCount);

            //}


            // display results on screen

            foreach (var item in wordFrequency.Where(m => m.NumberOfWords == 1).OrderByDescending(m => m.WeightedValue).Take(NumberToTake))
            {
                resultsBoxOneWord.AppendText($"{item.Keyword}\t{item.WeightedValue.ToString(formatString)}{Environment.NewLine}");
            }

            foreach (var item in wordFrequency.Where(m => m.NumberOfWords == 2).OrderByDescending(m => m.WeightedValue).Take(NumberToTake))
            {
                resultsBoxTwoWord.AppendText($"{item.Keyword}  {item.WeightedValue.ToString(formatString)}{Environment.NewLine}");
            }

            foreach (var item in wordFrequency.Where(m => m.NumberOfWords == 3).OrderByDescending(m => m.WeightedValue).Take(NumberToTake))
            {
                resultsBoxThreeWord.AppendText($"{item.Keyword}  {item.WeightedValue.ToString(formatString)}{Environment.NewLine}");
            }

            foreach (var item in wordFrequency.Where(m => m.NumberOfWords == 4).OrderByDescending(m => m.WeightedValue).Take(NumberToTake))
            {
                resultsBoxFourWord.AppendText($"{item.Keyword}  {item.WeightedValue.ToString(formatString)}{Environment.NewLine}");
            }

            foreach (var item in wordFrequency.Where(m => m.NumberOfWords != 1).OrderByDescending(m => m.WeightedValue).Take(NumberToTake).OrderBy(m => m.Keyword))
            {
                resultsBoxOverall.AppendText($"{item.Keyword}  {item.WeightedValue.ToString(formatString)}{Environment.NewLine}");
            }
        }

        private void AddKeywordsToResults(List<WeightedKeywordResult> wordFrequency, SEOKeyWord item, string word, int wordCount)
        {
            if (!wordFrequency.Where(m => m.Keyword == word).Any())
            {
                wordFrequency.Add(new WeightedKeywordResult { Keyword = word, WeightedValue = item.NumImpressions + (item.NumClicks * clicksToImpressions), NumberOfWords = wordCount });
            }
            else
            {
                int currentValue = wordFrequency.Where(m => m.Keyword == word).FirstOrDefault().WeightedValue;

                wordFrequency.Remove(wordFrequency.Where(m => m.Keyword == word).FirstOrDefault());

                wordFrequency.Add(new WeightedKeywordResult { Keyword = word, WeightedValue = currentValue + item.NumImpressions + (item.NumClicks * clicksToImpressions), NumberOfWords = wordCount });
            }
        }
    }
}
