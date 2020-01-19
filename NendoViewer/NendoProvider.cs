using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NendoViewer {
    public class NendoProvider {
        /// <summary>
        /// 指定した日を含む年度を返す。
        /// </summary>
        /// <param name="date">評価する日付</param>
        /// <returns>指定した日を含む年度</returns>
        public int GetYearFromDate(DateTime date) {
            return date.Year;
        }
    }
}
