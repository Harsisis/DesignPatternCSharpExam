

using DesignPatterns.Exam.Pattern.Interpretor.Expression;
using DesignPatterns.Exam.Pattern.Interpretor.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DesignPatterns.Exam.Pattern.Interpretor {
    public class Context {
        static Dictionary<string, List<string>> Tables = new Dictionary<string, List<string>>();
        public string Table { get; set; }
        public SelectTypeEnum Column { get; set; }
        public Predicate<string> Filter { get; set; }
        public Context() { }

        public List<string> Search() {
            List<string> result = new List<string>();
            List<List<string>> listTables = Tables.Where(x => x.Key.ToLower().Contains(Table.ToLower())).ToList().Select(x => x.Value).ToList();
            listTables.ForEach(table => {
                result.AddRange(table.FindAll(Filter));
            });
            switch (Column) {
                case SelectTypeEnum.ALL:
                    return result;
                case SelectTypeEnum.COUNT:
                    return new List<string>() { result.Count.ToString() };
            }
            return result;
        }
        static Context() {
            List<string> list = new List<string> {
                "00",
                "01",
                "02",
                "03",
                "04",
                "05",
                "06",
                "07",
                "08",
                "09",
                "10",
                "11",
                "12",
                "13",
                "14",
                "15",
                "16",
                "17",
                "18",
                "19",
                "20",
                "21",
                "22",
                "23",
                "24",
                "25",
                "26",
                "27",
                "28",
                "29",
                "30",
                "31",
                "32",
                "33",
                "34",
                "35",
                "36",
                "37",
                "38",
                "39"
            };
            Tables.Add("numbers", list);
            list = new List<string> {
                "A",
                "B",
                "C",
                "D",
                "E",
                "F",
                "G",
                "H",
                "I",
                "J",
                "K",
                "L",
                "M",
                "N",
                "O",
                "P",
                "Q",
                "R",
                "S",
                "T",
                "U",
                "V",
                "W",
                "X",
                "Y",
                "Z",
                "AA",
                "AB",
                "AC",
                "AD",
                "AE",
                "AF",
                "AG",
                "AH",
                "AI",
                "AJ",
                "AK",
                "AL",
                "AM",
                "AN",
                "AO",
                "AP",
                "AQ",
                "AR",
                "AS",
                "AT",
                "AU",
                "AV",
                "AW",
                "AX",
                "AY",
                "AZ"
            };
            Tables.Add("letters", list);
        }
    }
}
