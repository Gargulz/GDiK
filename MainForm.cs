using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GDiK
{
    public partial class MainForm : Form
    {
        private string input;
        private string binaryResult;
        public MainForm()
        {
            InitializeComponent();
        }

        // Конвертация числа
        private void btnConvert_Click(object sender, EventArgs e)
        {
            PerformConversion();
        }

        // Автоматическая конвертация при вводе
        private void txtDecimalInput_TextChanged(object sender, EventArgs e)
        {
            if (chkAutoCalculate.Checked)
            {
                PerformConversion();
            }
        }

        private void PerformConversion()
        {
            string input = txtDecimalInput.Text.Trim().Replace(".", ","); // Заменить точку на запятую

            if (!IsValidDecimal(input))
            {
                lblError.Text = "Некорректное значение!";
                txtBinaryResult.Text = string.Empty;
                return;
            }

            lblError.Text = string.Empty;

            try
            {
                double decimalNumber = Convert.ToDouble(input);
                string binaryResult = ConvertDecimalToBinary(decimalNumber);

                txtBinaryResult.Text = binaryResult;

                this.input = input;
                this.binaryResult = binaryResult;

                if (chkAutoSave.Checked)
                {
                    SaveToHistory(input, binaryResult);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при конвертации: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Проверка корректности ввода
        private bool IsValidDecimal(string input)
        {
            return Regex.IsMatch(input, @"^-?\d+(,\d+)?$");
        }

        // Конвертация числа в двоичную систему
        private string ConvertDecimalToBinary(double decimalNumber)
        {
            int integerPart = (int)decimalNumber;
            double fractionalPart = decimalNumber - integerPart;

            string binaryInteger = Convert.ToString(integerPart, 2);
            string binaryFraction = ConvertFractionToBinary(fractionalPart);

            return binaryFraction == "" ? binaryInteger : $"{binaryInteger}.{binaryFraction}";
        }

        // Конвертация дробной части
        private string ConvertFractionToBinary(double fractionalPart)
        {
            string result = "";
            int precision = 32; // Максимальная длина двоичной дробной части

            while (fractionalPart > 0 && result.Length < precision)
            {
                fractionalPart *= 2;
                int bit = (int)fractionalPart;
                result += bit.ToString();
                fractionalPart -= bit;

                // Защита от бесконечных циклов
                if (Math.Abs(fractionalPart - 0) < 1e-10)
                {
                    break;
                }
            }

            return result;
        }

        // Сохранение в историю
        private void SaveToHistory(string input, string result)
        {
            string entry = $"Decimal: {input} -> Binary: {result}";
            lstHistory.Items.Add(entry);

            if (chkSaveToFile.Checked)
            {
                SaveHistoryToFile(entry);
            }
        }

        // Сохранение истории в файл
        private void SaveHistoryToFile(string entry)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConversionHistory.txt");

            try
            {
                File.AppendAllText(filePath, entry + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения истории: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Очистка истории
        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            lstHistory.Items.Clear();
        }

        // Перенос результата в поле ввода
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (input != null && binaryResult != null)
                SaveToHistory(input, binaryResult);
        }
    }
}
