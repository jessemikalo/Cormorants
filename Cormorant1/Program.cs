using Cormorant1;
double populationOfFinland = 5518000;
double populationOfCormorants = 53400;
double year1 = 2018;
double populationGrowth = 1.08;
double newPopulationGrowth = 1.001;



double result1 = Calc.Divide(populationOfFinland, populationOfCormorants);
double duration = Calc.Divide(Math.Log(result1), Math.Log(populationGrowth));
double answerA = Calc.Add(year1, duration);
answerA = Convert.ToInt32(answerA);
Console.WriteLine("a) Number of cormorants equal to Finnish population " + answerA);
Console.WriteLine(" ");

double newGrowth = Calc.Power(newPopulationGrowth, duration);
double newPopulationOfFinland = Calc.Multiple(populationOfFinland, newGrowth);
double result3 = Calc.Divide(newPopulationOfFinland, populationOfCormorants);
double result4 = Calc.Divide(Math.Log(result3), Math.Log(populationGrowth));
double answerB = result4 + year1;
answerB = Convert.ToInt32(answerB);
Console.WriteLine("b) Number of cormorants equal to Finnish population " + answerB);


