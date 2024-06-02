using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class WordBank : MonoBehaviour
{
    public List<string> originalWords = new List<string>()
    {
        "Gawr Gura", "Usada Pekora", "Hoshimachi Suisei", "Tokino Sora", "Robocosan", "Aki Rosenthal", "Akai Haato", "Shirakami Fubuki", "Natsuiro Matsuri", "Minato Aqua", "Murasaki Shion", "Nakiri Ayame", "Yuzuki Choco", "Oozora Subaru", "aZKi", "Ookami Mio", "Sakura Miko", "Nekomata Okayu", "Inugami Korone", "Shiranui Flare", "Shirogane Noel", "Houshou Marine", "Amane Kanata", "Tsunomaki Watame", "Tokoyami Towa", "Himemori Luna", "Yukihana Lamy", "Momosuzu Nene", "Shishiro Botan", "Omaru Polka", "La+ Darkness", "Takane Lui", "Hakui Koyori", "Sakamata Chloe", "Kazama Iroha", "Ayunda Risu", "Moona Hoshinova", "Airani Iofifteen", "Kureiji Ollie", "Anya Melfissa", "Pavolia Reine", "Vestia Zeta", "Kaela Kovalskia", "Takanashi Kiara", "Ninomae Ina'nis", "Watson Amelia", "IRyS", "Ceres Fauna", "Ouro Kronii", "Nanashi Mumei", "Hakos Baelz", "Shiori Novella", "Koseki Bijou", "Nerissa Ravencroft", "Fuwawa Abyssgard", "Mococo Abyssgard", "Hiodoshi Ao", "Otonose Kanade", "Ichijou Ririka", "Juufuutei Raden", "Todoroki Hajime", "Kiryu Coco", "Tsukumo Sana", "Friend A", "Uruha Rushia", "Yozora Mel", "YAGOO", "Kobo Kanaeru", "Harusaki Nodoka"
    };

    public List<Sprite> wordImages; // List of sprites corresponding to each word

    private List<string> workingWords = new List<string>();
    private Dictionary<string, Sprite> wordToImageMap; // Mapping between words and images

    private void Awake()
    {
        workingWords.AddRange(originalWords);
        Shuffle(workingWords);
        ConvertToLower(workingWords);

        // Initialize the word-to-image map
        InitializeWordToImageMap();
    }

    private void InitializeWordToImageMap()
    {
        wordToImageMap = new Dictionary<string, Sprite>();
        for (int i = 0; i < originalWords.Count; i++)
        {
            wordToImageMap.Add(originalWords[i].ToLower(), wordImages[i]);
        }
    }

    private void Shuffle(List<string> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            int random = Random.Range(i, list.Count);
            string temporary = list[i];

            list[i] = list[random];
            list[random] = temporary;
        }
    }

    private void ConvertToLower(List<string> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            list[i] = list[i].ToLower();
        }
    }

    public string GetWord()
    {
        string newWord = string.Empty;

        if (workingWords.Count != 0)
        {
            newWord = workingWords.Last();
            workingWords.Remove(newWord);
        }

        return newWord;
    }

    public Sprite GetImageForWord(string word)
    {
        // Retrieve the image corresponding to the word
        if (wordToImageMap.ContainsKey(word))
        {
            return wordToImageMap[word];
        }
        return null;
    }
}
