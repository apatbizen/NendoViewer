using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NendoViewer {
    /// <summary>
    /// 
    /// </summary>
    public class NendoProvider {
        private readonly int firstMonthOfNendo;
        private readonly int firstDayOfNendo;
        private readonly ReferenceAt referenceAt;

        /// <summary>
        /// 指定した条件で年度を計算するインスタンスを生成します。
        /// </summary>
        /// <param name="firstMonth">期首月</param>
        /// <param name="firstDay">期首日</param>
        /// <param name="at">年度年の算出基準日</param>
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
            // 指定した日付の西暦年を基に計算を行う。
            int currentYear = date.Year;

            // 基準日が期末日の場合、期首日の場合に比べて1年後になるので1加算する。
            if (this.referenceAt == ReferenceAt.LastDate) currentYear += 1;

            // 現在の月日が期首日より前の場合1減算する。
            if (date.Month == firstMonthOfNendo && date.Day < firstDayOfNendo) currentYear -= 1;
            if (date.Month < firstMonthOfNendo) currentYear -= 1;

            // 上記計算を行い、が指定した日時点の年度を求める。
            return currentYear;
        }

        /// <summary>
        /// 年度年の算出基準日
        /// </summary>
        public enum ReferenceAt {
            /// <summary>期首日</summary>
            FirstDate,
            /// <summary>期末日</summary>
            LastDate
        }
    }
}
