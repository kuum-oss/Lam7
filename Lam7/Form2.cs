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
        this.Text = "Тестування";
        this.Size = new Size(500, 400);

        TabControl tabs = new TabControl { Dock = DockStyle.Fill };
        TabPage page1 = new TabPage { Text = "Тестування" };
        TabPage page2 = new TabPage { Text = "Налаштування" };

        // Використання SplitContainer
        SplitContainer split = new SplitContainer { Dock = DockStyle.Fill, Orientation = Orientation.Vertical };
        
        // Ліва панель - FlowLayoutPanel з питаннями
        FlowLayoutPanel flow = new FlowLayoutPanel { 
            Dock = DockStyle.Fill, 
            AutoScroll = true,
            FlowDirection = FlowDirection.TopDown,
            WrapContents = false
        };

        for (int i = 1; i <= 5; i++)
            flow.Controls.Add(new CheckBox { Text = "Питання " + i, Width = 150 });

        // Права панель - кнопка для переходу до Form3
        Button btnNext = new Button { Text = "Перейти до результатів (Form3)", Dock = DockStyle.Top, Height = 40 };
        btnNext.Click += (s, e) => {
            Form3 f3 = new Form3();
            f3.Show();
        };

        split.Panel1.Controls.Add(flow);
        split.Panel2.Controls.Add(btnNext);
        
        page1.Controls.Add(split);
        
        // Динамічне додавання елементів на другу вкладку
        Button btnAddTab = new Button { Text = "Додати нову вкладку", Location = new Point(10, 10), Size = new Size(150, 30) };
        btnAddTab.Click += (s, e) => {
            TabPage newPage = new TabPage { Text = "Додаткова " + (tabs.TabPages.Count + 1) };
            newPage.Controls.Add(new Label { Text = "Це динамічно створена вкладка", Location = new Point(10, 10) });
            tabs.TabPages.Add(newPage);
        };
        page2.Controls.Add(btnAddTab);

        tabs.TabPages.Add(page1);
        tabs.TabPages.Add(page2);

        this.Controls.Add(tabs);
        this.FormClosing += (s, e) => _parent.Close();
    }
}