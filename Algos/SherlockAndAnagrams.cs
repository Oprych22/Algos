using System;
using System.Collections.Generic;
using System.Text;

namespace Algos
{
    public static class SherlockAndAnagrams
    {
        static string GiveKey(int[] arr){
            StringBuilder sb = new StringBuilder();
            for(int i = 0 ; i < 26 ; i++){
                sb.AppendFormat("{0}-",arr[i]);
            }
            return sb.ToString();
        }
        static long sherlockAndAnagrams(string s)
        {
            Dictionary<string,int> dict = new Dictionary<string,int>();
            for(int i = 0 ; i < s.Length;i++){
                int[] count = new int[26];
                for(int j = i ; j < s.Length ; j++){
                    int acode = (int)s[j] - (int)'a';
                    count[acode]++;
                    string key = GiveKey(count);
                    //Console.WriteLine
                    if(!dict.ContainsKey(key))
                        dict.Add(key,0);
                    dict[key]++;
                }
            }
            long total = 0 ;
            foreach(var item in dict){
                if(item.Value > 1){
                    //Console.WriteLine(item.Value + " " + item.Key);
                    total = total + (item.Value * (item.Value - 1)) / 2;
                    //total = total - 1;
                }
            }

            return total;
        }

        // static void Main()
        // {
        //     sherlockAndAnagrams("kkkk");
        // }
    }
}