﻿using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace ELIZA.NET.Structures
{
    [Serializable]
    public class Keyword
    {
        [JsonProperty("genericResponses")]
        private string Word = null;

        [JsonProperty("genericResponses")]
        private string Script = null;

        [JsonProperty("genericResponses")]
        private int Rank = 0;

        [JsonProperty("genericResponses")]
        private List<Rule> Rules = null;

        public Keyword(string word, string script, int rank, List<Rule> rules)
        {
            this.Word = word;
            this.Script = script;
            this.Rank = rank;
            this.Rules = rules;
        }

        public Keyword() { }

        public string GetWord()
        {
            return Word;
        }

        public void SetWord(string word)
        {
            this.Word = word;
        }

        public string GetScript()
        {
            return Script;
        }

        public void SetScript(string script)
        {
            this.Script = script;
        }

        public int GetRank()
        {
            return Rank;
        }

        public void SetRank(int rank)
        {
            this.Rank = rank;
        }

        public List<Rule> GetRules()
        {
            return Rules;
        }

        public void SetRules(List<Rule> rules)
        {
            this.Rules = rules;
        }
    }
}
