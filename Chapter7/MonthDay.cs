﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
    class MonthDay
    {
        //プロパティ
        public int Day { get; private set; }
        public int Month { get; private set; }

        //コンストラクタ
        public MonthDay(int month, int day)
        {
            this.Month = month;
            this.Day = day;
        }

        //MonthDay同士の比較をする
        public override bool Equals(object obj)
        {
            var other = obj as MonthDay;//オブジェクトをキャストする時は『as』を使う
            if (other == null)
            {
                throw new ArgumentException();
            }
            return this.Day == other.Day && this.Month == other.Month;
        }

        //ハッシュコードを求める
        public override int GetHashCode()
        {
            return Month.GetHashCode() * 31 + Day.GetHashCode();
        }
    }
}
