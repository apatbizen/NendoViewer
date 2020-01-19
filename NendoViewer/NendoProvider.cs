using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NendoViewer {
    public class NendoProvider {
        private int firstMonthOfNendo;
        private int firstDayOfNendo;

        public NendoProvider(int firstMonth, int firstDay) {
            this.firstMonthOfNendo = firstMonth;
            this.firstDayOfNendo = firstDay;
        }

        /// <summary>
        /// 指定した日を含む年度を返す。
        /// </summary>
        /// <param name="date">評価する日付</param>
        /// <returns>指定した日を含む年度</returns>
        public int GetYearFromDate(DateTime date) {
            if (date.Month <= 3) return date.Year - 1;
            return date.Year;
        }
    }
}
