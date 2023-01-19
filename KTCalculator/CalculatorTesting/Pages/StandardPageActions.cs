using System;

namespace Testing.Pages
{
    public partial class StandardPage
    {
        public void InputNumber(string numberAsString)
        {
            foreach(var character in numberAsString)
            {
                if (Char.IsDigit(character))
                {
                    DigitButtons.Find(b => Char.Parse(b.GetName()) == character).Click();
                }
                else if(character == '.')
                {
                    DecimalSeparatorButton.Click();
                }
            }

        }

        public void AddNumber(string numberAsString)
        {
            AddButton.Click();
            InputNumber(numberAsString);
            EqualsButton.Click();
        }
        public void AddResultToMemory()
        {
            MemoryAddButton.Click();
        }

        public void AddFromMemory()
        {
            AddButton.Click();
            MemoryRecallButton.Click();
            EqualsButton.Click();
        }

        public string GetResult()
        {
            return ResultLabel.GetName();
        }
    }
}
