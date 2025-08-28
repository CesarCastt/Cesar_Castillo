using System;

namespace Prueba1.Helpers
{
    public static class Calculos
    {
        public static float CalcularPromedioNotas(float n1, float n2, float n3, float n4, int p1, int p2, int p3, int p4)
        {
            float factor1 = p1 / 100f;
            float factor2 = p2 / 100f;
            float factor3 = p3 / 100f;
            float factor4 = p4 / 100f;

            float promedioPonderado = n1 * factor1 + n2 * factor2 + n3 * factor3 + n4 * factor4;
            return promedioPonderado;
        }

        public static float CalcularPromedioFinal(float promedioNotas, float notaExamen)
        {
            return promedioNotas * 0.7f + notaExamen * 0.3f;
        }

        public static float CalcularNotaNecesaria(float promedioNotas)
        {
            float notaNecesaria = (4.0f - promedioNotas * 0.7f) / 0.3f;

            if (notaNecesaria < 1.0f) notaNecesaria = 1.0f;
            if (notaNecesaria > 7.0f) notaNecesaria = 7.0f;

            return notaNecesaria;
        }
    }
}
