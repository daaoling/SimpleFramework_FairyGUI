using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class IllegalWoirDetectionV1
{
    static HashSet<string> hash = new HashSet<string>();

    private static BitArray firstCharCheck = new BitArray(char.MaxValue);
    private static BitArray allCharCheck = new BitArray(char.MaxValue);
    private static int maxLength = 0;
    public static void Init(string[] badwords)
    {
        foreach (string word in badwords)
        {
            if (!hash.Contains(word))
            {
                hash.Add(word);
                maxLength = Mathf.Max(maxLength, word.Length);
                
                firstCharCheck[word[0]] = true;

                foreach (char c in word)
                {
                    allCharCheck[c] = true;
                }
            }
        }
    }
    unsafe public static string Filter(string text, string mask = "*")
    {
        Dictionary<int, int> dic = DetectIllegalWords(text);
        ///如果没有敏感词汇，则直接返回出去
        if (dic.Count == 0)
            return text;

        fixed (char* newText = text, cMask = mask)
        {
            var itor = newText;
            Dictionary<int, int>.Enumerator enumerator = dic.GetEnumerator();
            ///开始替换敏感词汇
            while (enumerator.MoveNext())
            {
                ///偏移到敏感词出现的位置
                itor = newText + enumerator.Current.Key;
                for (int index = 0; index < enumerator.Current.Value; index++)
                {
                    ///屏蔽掉敏感词汇
                    *itor++ = *cMask;
                }
            }
            enumerator.Dispose();
        }

        return text;
    }

    public static Dictionary<int, int>  DetectIllegalWords(string text)
    {
        var findResult = new Dictionary<int, int>();

        int index = 0;
        int offset = 0;
        while (index < text.Length)
        {
            if (!firstCharCheck[text[index]])
            {
                while (index < text.Length - 1 && !firstCharCheck[text[++index]]) ;
            }

            for (int j = 1; j <= Mathf.Min(maxLength, text.Length - index); j++)
            {
                if (!allCharCheck[text[index + j - 1]])
                {
                    break;
                }

                string sub = text.Substring(index, j);

                if (hash.Contains(sub))
                {
                    //return true;
                    findResult.Add(index, j);
                    break;
                }
            }

            index++;
        }

        return findResult;
    }
	
}
