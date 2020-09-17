using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Currency
{
    class Logic
    {
        ValCurs valCurs;

        /// <summary>
        /// For now returning Hongkong's valute
        /// TODO: Changing valute witn combobox
        /// </summary>
        /// <param name="foreignLbl">Name in foreign label</param>
        /// <param name="foreignTb">Value in foreign textbox</param>
        /// <param name="rublTb">Value in ruble textbox</param>
        public void ValuteChanged(ref string foreignLbl, ref string foreignTb, ref string rublTb)
        {
            valCurs = XmlCurrency.DeserializeList();
            foreignLbl = valCurs.Valute[8].CharCode;
            foreignTb = valCurs.Valute[8].Nominal.ToString();
            rublTb = valCurs.Valute[8].ValueCur;
        }

        public string RublesChanged(string valChanged)
        {
            return CalculateValue(valChanged, false);
        }

        public string ForeignChanged(string valChanged)
        {
            return CalculateValue(valChanged, true);
        }

        /// <summary>
        /// Calculating value
        /// </summary>
        /// <param name="valChanged">User's entered value</param>
        /// <param name="isForeign">Is foreign tb was changed</param>
        /// <returns>Calculated string for tb</returns>
        public string CalculateValue(string valChanged, bool isForeign)
        {
            double firstVal;
            double secndVal = Convert.ToDouble(valCurs.Valute[8].ValueCur) / valCurs.Valute[8].Nominal;
            valChanged = valChanged.Replace(',', '.');
            if(double.TryParse(valChanged, out firstVal) && isForeign)
            {
                return Convert.ToString(secndVal * firstVal);
            }
            else if(double.TryParse(valChanged, out firstVal) && !isForeign)
            {
                return Convert.ToString(firstVal / secndVal);
            }
            else
            {
                return "Nan";
            }
        }
    }
}
