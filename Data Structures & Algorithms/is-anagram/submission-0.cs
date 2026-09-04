public class Solution {
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }
        
        Dictionary<char, int> schars = new Dictionary<char, int>();
        Dictionary<char, int> tchars = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (schars.ContainsKey(s[i]))
            {
                schars[s[i]]++;
            }
            else
            {
                schars.Add(s[i], 1);
            }
        if (tchars.ContainsKey(t[i]))
            {
                tchars[t[i]]++;
            }
            else
            {
                tchars.Add(t[i], 1);
            }
        }

        if (schars.Count != tchars.Count) 
        {
            return false;
        }

        foreach (var c in schars)
        {
            if(!tchars.ContainsKey(c.Key) || tchars[c.Key] != c.Value)
            {
                return false;
            }
        }
        return true;
    }
}
