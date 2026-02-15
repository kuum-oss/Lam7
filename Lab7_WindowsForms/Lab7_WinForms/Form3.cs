using System.Drawing;
using System.Windows.Forms;

namespace Lam7;

public class Form3 : Form
{
    public Form3()
    {
        this.Text = "Табличний контейнер";
        this.Size = new Size(400, 300);

        TableLayoutPanel table = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, RowCount = 2 };
        table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

        table.Controls.Add(new Label { Text = "Локація (0,0)", Dock = DockStyle.Fill }, 0, 0);
        table.Controls.Add(new Button { Text = "Кнопка (1,1)", Dock = DockStyle.Fill }, 1, 1);

        this.Controls.Add(table);
    }
}
