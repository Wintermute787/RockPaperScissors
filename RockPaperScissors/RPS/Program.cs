using System;

namespace RockPaperScissors
{
    class MainClass
    {
        public static void Main()
        {
            bool CheckToSeeIfTheUserInputRockPaperOrScissorsORQuitButOnlySetToTrueIfTheUserEntersQuit = false;

            while (!CheckToSeeIfTheUserInputRockPaperOrScissorsORQuitButOnlySetToTrueIfTheUserEntersQuit)
            {
                Console.WriteLine("Enter Rock/Paper/Scissors/QUIT");

                string ThisHoldsTheUserInputOfRockPaperScissorsOrQuitAndMakesAllOfTheLettersLowerCaseSoThatWeKeepOurCodeSimpleAndDontMakeThingsMessedUpYouKnowWhatIMean = Console.ReadLine().ToLower();
                CheckToSeeIfTheUserInputRockPaperOrScissorsORQuitButOnlySetToTrueIfTheUserEntersQuit = ThisHoldsTheUserInputOfRockPaperScissorsOrQuitAndMakesAllOfTheLettersLowerCaseSoThatWeKeepOurCodeSimpleAndDontMakeThingsMessedUpYouKnowWhatIMean == "quit";
                rpsLogic epicodusRpsVariableNameForObjectInRockPaperScissors = new rpsLogic(ThisHoldsTheUserInputOfRockPaperScissorsOrQuitAndMakesAllOfTheLettersLowerCaseSoThatWeKeepOurCodeSimpleAndDontMakeThingsMessedUpYouKnowWhatIMean);
                bool TrueOrFalseDependindOnifTheUserInputForRockPaPerScissorsBeatsTheCpuRandomChoiceOfRockPaperOrScissors = epicodusRpsVariableNameForObjectInRockPaperScissors.CheckWin(epicodusRpsVariableNameForObjectInRockPaperScissors.GetChoice(), epicodusRpsVariableNameForObjectInRockPaperScissors.cpuWord().ToLower());
                if (TrueOrFalseDependindOnifTheUserInputForRockPaPerScissorsBeatsTheCpuRandomChoiceOfRockPaperOrScissors && !CheckToSeeIfTheUserInputRockPaperOrScissorsORQuitButOnlySetToTrueIfTheUserEntersQuit)
                {
                    Console.WriteLine("CPU choys: " + epicodusRpsVariableNameForObjectInRockPaperScissors.GetCPU());
                    Console.WriteLine("YOU WIN");
                }
                else
                {
                    Console.WriteLine("CPU choys: " + epicodusRpsVariableNameForObjectInRockPaperScissors.GetCPU());
                    Console.WriteLine("YOU SUCK EVEN THOUGH IT MIGHT BE A TIE. WE DIDNT INCLUDE A CHECK FOR THAT. TOO BAD, LOSER");
                }
            }
        }
    }
}