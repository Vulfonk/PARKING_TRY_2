using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARKING_TRY_2
{
    public enum InputStatus
    {
        Input,
        Output,
    }

    public static class InputStatusConverter
    {
        public static InputStatus StringToStatus(string str)
        {
            return str == "Вход" ? InputStatus.Input : InputStatus.Output;
        }

        public static string StatusToString(InputStatus status)
        {
            return status == InputStatus.Input ? "Вход" : "Выход";
        }
    }


    public class Passage
    {
        public DateTime DateTime;
        public string FullName;
        public InputStatus InputStatus;
    }
}
