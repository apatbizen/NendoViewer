using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NendoViewer {
    public class NendoProvider {
        private int firstMonthOfNendo;
        private int firstDayOfNendo;

        public NendoProvider(int firstMonth, int firstDay, ReferenceAt at = ReferenceAt.FirstDate) {
            this.firstMonthOfNendo = firstMonth;
            this.firstDayOfNendo = firstDay;
        }

        /// <summary>
        /// 指定した日を含む年度を返す。
        /// </summary>
        /// <param name="date">評価する日付</param>
        /// <returns>指定した日を含む年度</returns>
        public int GetYearFromDate(DateTime date) {
            if (date.Month < firstMonthOfNendo) return date.Year - 1;
            if (date.Month == firstMonthOfNendo && date.Day < firstDayOfNendo) return date.Year - 1;
            return date.Year;
        }

        public enum ReferenceAt {
            FirstDate,
            LastDate
        }
    }
}
