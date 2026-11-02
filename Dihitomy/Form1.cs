using System;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;
using NCalc;

namespace Dihitomy
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void рассчитатьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      string formula = txtFunction.Text.Trim();

      if (string.IsNullOrWhiteSpace(formula))
      {
        MessageBox.Show("Введите формулу f(x).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      try
      {
        double A = ExtractCoefficient(formula, "x^2");
        double B = ExtractCoefficient(formula, "x");
        double C = ExtractConstant(formula);

        if (Math.Abs(A) < 1e-10)
        {
          MessageBox.Show("Это не квадратное уравнение, Ошибка");
          return;
        }

        if (rbDichotomy.Checked)
        {
          SolveByDiscriminant(A, B, C, formula);
        }
        else if (rbGolden.Checked)
        {
          SolveByVieta(A, B, C, formula);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Не удалось распознать квадратное уравнение, Ошибка");
      }
    }

    private void SolveByDiscriminant(double A, double B, double C, string formula)
    {
      double D = B * B - 4 * A * C;

      string result = "=== Результат (Дискриминант) ===\r\n" +
                      $"Формула: {formula}\r\n" +
                      $"Коэффициенты: A = {A}, B = {B}, C = {C}\r\n" +
                      $"Дискриминант: D = {D}\r\n\r\n";

      if (D < 0)
      {
        result += "Корней нет (D < 0).";
      }
      else if (Math.Abs(D) < 1e-10)
      {
        double x = -B / (2 * A);
        result += $"Один корень (D = 0): x = {x:F6}\r\n";
      }
      else
      {
        double x1 = (-B + Math.Sqrt(D)) / (2 * A);
        double x2 = (-B - Math.Sqrt(D)) / (2 * A);
        result += $"Корень 1: x1 = {x1:F6}\r\n" +
                  $"Корень 2: x2 = {x2:F6}\r\n";
      }

      txtResult.Text = result;
    }

    private void SolveByVieta(double A, double B, double C, string formula)
    {
      string result = "=== Результат (Теорема Виета) ===\r\n" +
                      $"Формула: {formula}\r\n" +
                      $"Сумма корней (x1 + x2) = {-B / A:F4}\r\n" +
                      $"Произведение корней (x1 * x2) = {C / A:F4}\r\n\r\n";

      double sum = -B / A;
      double product = C / A;
      double D = B * B - 4 * A * C;

      if (D < 0)
      {
        result += "Корней нет (дискриминант отрицательный).";
      }
      else
      {
        double x1 = (sum + Math.Sqrt(sum * sum - 4 * product)) / 2;
        double x2 = (sum - Math.Sqrt(sum * sum - 4 * product)) / 2;

        result += $"Найденные корни:\r\n" +
                  $"x1 = {x1:F6}\r\n" +
                  $"x2 = {x2:F6}\r\n\r\n" +
                  $"Проверка Виета:\r\n" +
                  $"x1 + x2 = {x1 + x2:F4} (должно быть {sum:F4})\r\n" +
                  $"x1 * x2 = {x1 * x2:F4} (должно быть {product:F4})\r\n";
      }

      txtResult.Text = result;
    }

    private double ExtractCoefficient(string formula, string term)
    {
      formula = formula.Replace(" ", "");

      if (term == "x")
      {
        formula = formula.Replace("x^2", "");
      }

      Match match = Regex.Match(formula, @"([+-]?\d*\.?\d*)\*?" + Regex.Escape(term));

      if (match.Success)
      {
        string coeffStr = match.Groups[1].Value;
        if (string.IsNullOrEmpty(coeffStr) || coeffStr == "+") return 1;
        if (coeffStr == "-") return -1;
        return double.Parse(coeffStr, CultureInfo.InvariantCulture);
      }

      if (formula.Contains(term)) return 1;
      return 0;
    }

    private double ExtractConstant(string formula)
    {
      formula = formula.Replace(" ", "").Replace("x^2", "").Replace("x", "");
      Match match = Regex.Match(formula, @"([+-]?\d+\.?\d*)$");
      if (match.Success)
        return double.Parse(match.Groups[1].Value, CultureInfo.InvariantCulture);
      return 0;
    }
    private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      txtFunction.Text = "";
      txtResult.Text = "";
    }

    private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Лабораторная работа: Дискриминант и Теорема Виета\r\n© 2026", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void выходToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}