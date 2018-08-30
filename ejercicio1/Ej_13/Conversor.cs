﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_13
{
    class Conversor
    {
        public static string DecimalBinario(double numeroDecimal)
        {
            string numeroBinario = "";
            long cociente = (long)numeroDecimal;
            long resto = (long)numeroDecimal;

            while (cociente >= 1)
            {
                resto = cociente % 2;
                cociente = cociente / 2;
                
                if (resto != 0)
                {
                    numeroBinario = "1" + numeroBinario;
                }
                else
                {
                    numeroBinario = "0" + numeroBinario;
                }
            }

            return numeroBinario;
        } 

        public static double BinarioDecimal(string numeroBinario)
        {
            double numeroDecimal = 0;
            int potencia = 1;

            for (int i = numeroBinario.Length - 1; i >= 0 ; i--)
            {   
                if (numeroBinario[i] == '1')
                {
                    numeroDecimal += potencia;
                }
                potencia *= 2;
            }

            return numeroDecimal;
        }
    }
}
