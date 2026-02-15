using System;
using System.Windows.Forms;

namespace Lam7; // Переконайся, що тут саме Lam7

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Form1()); // Запуск головної форми реєстрації
    }
}