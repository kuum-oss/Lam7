using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lam7;

public class Form2 : Form
{
    private Form _parent;
    public Form2(Form parent)
    {
        _parent = parent;
        this.Text = "Форма тестування";
        this.Size = new Size(600, 500);

        TabControl tabs = new TabControl { Dock = DockStyle.Fill };
        
        // Вкладка 1: SplitContainer та FlowLayoutPanel
        TabPage page1 = new TabPage { Text = "Контейнери" };
        SplitContainer split = new SplitContainer { Dock = DockStyle.Fill, Orientation = Orientation.Vertical };
        
        FlowLayoutPanel flow = new FlowLayoutPanel { Dock = DockStyle.Fill, FlowDirection = FlowDirection.TopDown, AutoScroll = true };
        
        // Динамічне додавання компонентів
        for (int i = 1; i <= 5; i++) {
            flow.Controls.Add(new CheckBox { Text = "Питання " + i, Width = 150 });
        }

        Button btnNext = new Button { Text = "До таблиці (Form3)", Location = new Point(10, 10) };
        btnNext.Click += (s, e) => new Form3().Show();

        split.Panel1.Controls.Add(flow);
        split.Panel2.Controls.Add(btnNext);
        page1.Controls.Add(split);
        
        tabs.TabPages.Add(page1);
        this.Controls.Add(tabs);
        this.FormClosing += (s, e) => _parent.Show();
    }
}
