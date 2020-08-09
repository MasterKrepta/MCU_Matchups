using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;

namespace MCU_Matchup.Library.Logic
{
    public class ScenarioRules
    {

        

        public float IntelligenceMultiplyer { get; set; }
        public float StrengthMulitplyer { get; set; }
        public float SpeedMultiplyer { get; set; }
        public float DurabilityMultiplyer { get; set; }
        public float PowerMultiplyer { get; set; }
        public float CombatMultiplyer { get; set; }

        public Stack<string> Stats = new Stack<string>();
   

        public string PrimaryStat { get; set; } 
        public string SecondaryStat { get; set; }
        public string TertiaryStat { get; set; }


        public ScenarioRules()
        {
            IntelligenceMultiplyer = GetRandomStatModifer();
            StrengthMulitplyer = GetRandomStatModifer();
            SpeedMultiplyer = GetRandomStatModifer();
            DurabilityMultiplyer = GetRandomStatModifer();
            PowerMultiplyer = GetRandomStatModifer();
            CombatMultiplyer = GetRandomStatModifer();

            GetRandomWinningStatValues();
        }

        float GetRandomStatModifer()
        {
            Random rnd = new Random();
            List<string> modifiers = new List<string>()
        {
            "1",
            "1.5",
            "2",
            "2.5",
            "3",
            "4"
        };

            return rnd.Next(modifiers.Count);
        }

        void GetRandomWinningStatValues()
        {
            ConfigStack();
            Shuffle(Stats);
            PrimaryStat = Stats.Pop();
            SecondaryStat = Stats.Pop();
            TertiaryStat = Stats.Pop();
        }

        private void ConfigStack()
        {
            Stats.Push("Intelligence");
            Stats.Push("Strength");
            Stats.Push("Speed");
            Stats.Push("Durability");
            Stats.Push("Power");
            Stats.Push("Combat");
        }

        public void Shuffle<T>(Stack<T> stack)
        {
            Random rnd = new Random();
            
            var values = stack.ToArray();
            stack.Clear();
            foreach (var value in values.OrderBy(x => rnd.Next()))
            {
                stack.Push(value);
            }
        }
    }
}
