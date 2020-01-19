using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NendoViewer {
    public class NendoProvider {
        private int firstMonthOfNendo;
        private int firstDayOfNendo;
        private ReferenceAt referenceAt;

        public NendoProvider(int firstMonth, int firstDay, ReferenceAt at = ReferenceAt.FirstDate) {
            this.firstMonthOfNendo = firstMonth;
            this.firstDayOfNendo = firstDay;
            this.referenceAt = at;
        }

        /// <summary>
        /// 指定した日を含む年度を返す。
        /// </summary>
        /// <param name="date">評価する日付</param>
        /// <returns>指定した日を含む年度</returns>
        public int GetYearFromDate(DateTime date) {
            int currentYear = date.Year;
            if (this.referenceAt == ReferenceAt.LastDate) currentYear += 1;
            if (date.Month == firstMonthOfNendo && date.Day < firstDayOfNendo) currentYear -= 1;
            if (date.Month < firstMonthOfNendo) currentYear -= 1;
            return currentYear;
        }

        public enum ReferenceAt {
            FirstDate,
            LastDate
        }
    }
}
