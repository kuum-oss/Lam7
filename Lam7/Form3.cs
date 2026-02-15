using System.Drawing;
using System.Windows.Forms;

namespace Lam7;

public class Form3 : Form
{
    public Form3()
    {
        this.Text = "Результати - TableLayoutPanel";
        this.Size = new Size(400, 300);
        
        // Створюємо табличний контейнер (TableLayoutPanel)
        TableLayoutPanel table = new TableLayoutPanel { 
            Dock = DockStyle.Fill, 
            ColumnCount = 2, 
            RowCount = 3,
            CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        };

        // Налаштування стилів стовпців та рядків (як у теоретичних відомостях)
        table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        
        table.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        table.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));

        // Додавання елементів до таблиці
        table.Controls.Add(new Label { Text = "Параметр", Font = new Font(this.Font, FontStyle.Bold), Anchor = AnchorStyles.None }, 0, 0);
        table.Controls.Add(new Label { Text = "Значення", Font = new Font(this.Font, FontStyle.Bold), Anchor = AnchorStyles.None }, 1, 0);
        
        table.Controls.Add(new Label { Text = "Загальний час:", Anchor = AnchorStyles.Left }, 0, 1);
        table.Controls.Add(new Label { Text = "00:05:23", Anchor = AnchorStyles.Right }, 1, 1);
        
        Button btnClose = new Button { Text = "Закрити", Dock = DockStyle.Fill };
        btnClose.Click += (s, e) => this.Close();
        table.Controls.Add(btnClose, 0, 2);
        // Залишаємо одну комірку порожньою або додаємо щось динамічно

        this.Controls.Add(table);
    }
}