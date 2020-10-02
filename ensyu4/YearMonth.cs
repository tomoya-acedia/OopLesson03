using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ensyu4
{
    class YearMonth
    {
        //年・月プロパティ(読み取り専用)
        public int Year { get; private set; }
        public int Month { get; private set; }

        //21世紀プロパティ
        public bool Is21Century
        {
            get
            {
                //2001年～2100年までが21世紀
                return 2001 <= Year && Year <= 2100;
            }
        }

        //コンストラクタ
        public YearMonth(int year, int month)
        {
            Year = year;
            Month = month;
        }

        //1ヵ月後を求める
        public YearMonth AddOneMonth()
        {
            //1～11月のとき
            if (this.Month == 12)
            {
                return new YearMonth(Year + 1, 1);
            }

            //12月のとき
            else
            {
                return new YearMonth(this.Year, this.Month + 1);
            }
        }

        //ToString()メソッドのオーバーライド
        public override string ToString()
        {
            return $"{Year}年{Month}月";
        }
    }
}
