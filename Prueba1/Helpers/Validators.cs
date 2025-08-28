using System;

namespace Prueba1.Helpers
{
    public static class Validators
    {
        public static bool ValidateName(string name)
        {
            return !string.IsNullOrWhiteSpace(name);
        }

        public static bool ValidateGrade(string input, out float grade)
        {
            if (float.TryParse(input, out grade))
            {
                if (grade >= 1.0f && grade <= 7.0f)
                    return true;
            }
            return false;
        }

        public static bool ValidateWeight(string input, out int weight)
        {
            if (int.TryParse(input, out weight))
            {
                if (weight >= 10 && weight <= 50)
                    return true;
            }
            return false;
        }

        public static bool ValidateTotalWeight(int w1, int w2, int w3, int w4)
        {
            return (w1 + w2 + w3 + w4) == 100;
        }
    }
}
