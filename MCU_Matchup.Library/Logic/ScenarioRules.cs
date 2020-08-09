using System;
using System.Collections.Generic;
using System.Text;

namespace MCU_Matchup.Library.Logic
{
    public class ScenarioRules
    {

   

        public float IntelligeneMultiplyer { get; set; }
        public float StrengthMulitplyer { get; set; }
        public float SpeedMultiplyer { get; set; }
        public float DurabilityMultiplyer { get; set; }
        public float PowerMultiplyer { get; set; }
        public float CombatMultiplyer { get; set; }


        public ScenarioRules()
        {
            IntelligeneMultiplyer = GetRandomStatModifer();
            StrengthMulitplyer = GetRandomStatModifer();
            SpeedMultiplyer = GetRandomStatModifer();
            DurabilityMultiplyer = GetRandomStatModifer();
            PowerMultiplyer = GetRandomStatModifer();
            CombatMultiplyer = GetRandomStatModifer();
        }

        float GetRandomStatModifer()
        {
            List<string> modifiers = new List<string>()
        {
            "1",
            "1.5",
            "2",
            "2.5",
            "3",
            "4"
        };
            Random rnd = new Random();

            return rnd.Next(modifiers.Count);
        }
    }
}
