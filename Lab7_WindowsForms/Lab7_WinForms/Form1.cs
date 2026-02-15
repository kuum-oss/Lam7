using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lam7;

public class Form1 : Form
{
    public Form1()
    {
        this.Text = "Реєстрація";
        this.Size = new Size(300, 250);
        this.StartPosition = FormStartPosition.CenterScreen;

        GroupBox group = new GroupBox { Text = "Вхід", Location = new Point(10, 10), Size = new Size(260, 100) };
        Label lbl = new Label { Text = "Логін:", Location = new Point(10, 35), AutoSize = true };
        TextBox txt = new TextBox { Location = new Point(80, 32), Width = 150 };
        
        Button btn = new Button { Text = "До тестування", Location = new Point(80, 130), AutoSize = true };

        btn.Click += (s, e) => {
            Form2 f2 = new Form2(this);
            f2.Show();
            this.Hide();
        };

        group.Controls.Add(lbl);
        group.Controls.Add(txt);
        this.Controls.Add(group);
        this.Controls.Add(btn);
    }
}
