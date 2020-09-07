using System;
using System.Diagnostics;
using System.Linq;

namespace Console_shaper
{
    public static class Himekuri
    {
        public static void Main(string[] args)
        {
            try
            {
                // 宣言
                var dt = DateTime.Now;
                const string str = "令和";
                const string str2 = "R0";

                // 計算
                var reiwa = (str + (dt.Year - 2018) + "年" + dt.Month + "月" + dt.Day + "日");
                var reiwa2 = (str2 + (dt.Year - 2018) + "." + dt.Month + "." + dt.Day);

                // 入れ子
                var count = new DateTime(dt.Year, dt.Month, dt.Day);
                var count2 = new DateTime(dt.Year + 1, 1, 1);
                var gantan = (count2 - count).TotalDays;

                // 参照先
                var nengo = (dt.Year + "年" + dt.Month + "月" + dt.Day + "日" + " : " + dt.Hour + "時" + dt.Minute + "分" +
                             dt.Second + "秒" + " : " + dt.ToString("dddd"));
                var hagoita = reiwa + " : " + reiwa2;
                var oshogatsu = "来年の1月1日まであと：" + (gantan - 1) + "日です。";

                // 安定ソート
                var takoage = new[]
                {
                    oshogatsu,
                    hagoita,
                    nengo
                };

                var orderByList = takoage.OrderBy(x => x);
                foreach (var x in orderByList )
                {
                    Console.WriteLine(x);
                }
            }

            catch (Exception e)
            {
                // 出力
                Trace.WriteLine(e.Message);
                Console.ReadKey();
            }
            finally
            {
                try
                {
                    // 宣言
                    const string RivisionNumber = "1.0.2R1";
                    const string himekuriShaperVersion = "日めくりの数え番号：";

                    // 安定ソート
                    var versioner = new[]
                    {
                        himekuriShaperVersion + RivisionNumber
                    };

                    var orderList = versioner.OrderBy(y => y);

                    foreach (var y in orderList)
                    {
                        Console.WriteLine(y);
                    }
                }
                catch (Exception ex)
                {
                    Trace.WriteLine(ex.Message);
                    Console.ReadKey();
                }
                finally
                {
                    Console.ReadKey();
                }
            }
        }
    }
}
